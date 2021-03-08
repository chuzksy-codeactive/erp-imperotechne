using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models.Account;
using JPSAGE_ERP.Application.Models.Responses;
using JPSAGE_ERP.Application.Services;
using JPSAGE_ERP.Domain.Entities;
using JPSAGE_ERP.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JPSAGE_ERP.WebAPI.Controllers
{
    /// <summary>
    /// This controller is in charge of the authentication and authorization in the application
    /// </summary>
    [Route("api/v1/users")]
    [ApiController]
    [Produces("application/json")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly IRepository<TblCountry> _countryRepository;
        private readonly IRepository<TblCity> _cityRepository;
        private readonly IRepository<TblState> _stateRepository;
        private readonly IRepository<TblStaffBioData> _staffRepository;
        private readonly IEmailTemplate _emailTemplate;
        private readonly IRepository<TblCompanyInfo> _company;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            IRepository<TblCountry> countryRepository,
            IRepository<TblCity> cityRepository,
            IRepository<TblState> stateRepository,
            IRepository<TblStaffBioData> staffRepository,
            IConfiguration configuration, IEmailTemplate emailTemplate, IRepository<TblCompanyInfo> company)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _countryRepository = countryRepository;
            _cityRepository = cityRepository;
            _stateRepository = stateRepository;
            _staffRepository = staffRepository;
            Configuration = configuration;
            _emailTemplate = emailTemplate;
            _company = company;
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// Registers a User
        /// </summary>
        /// <response code="200"> Returns registered username and email with a success message</response>
        /// <response code="400">Returns all error description</response>
        /// <param name="RegData"></param>
        /// <returns></returns>
        //[Authorize("RequireAdministratorRole")]
        //[ApiKeyAuth]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Authorize("RequireAdministratorRole")]
        [HttpPost("register")]
        public async Task<IActionResult> Register(
            //[FromHeader(Name = "REST-api-key"), Required] string apiKey, 
            [FromBody] RegisterViewModel RegData)
        {
            // Will hold all errors related to registration 
            List<string> errorList = new List<string>();

            // server side validation for User object
            if (ModelState.IsValid)
            {
                if (!Enum.IsDefined(typeof(ERoles), RegData.RoleId))
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Role is not defined",
                        data = new { }
                    });
                }

                var company = await _company.ExistsAsync(x => x.CompanyId == RegData.CompanyId);

                if (!company)
                {
                    return NotFound(new
                    {
                        success = false,
                        message = "Company is not found",
                        data = new { }
                    });
                }

                var user = new ApplicationUser
                {
                    Email = RegData.Email,
                    UserName = RegData.Email,
                    FirstName = RegData.FirstName,
                    LastName = RegData.LastName,
                    PhoneNumber = RegData.PhoneNumber,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                // create identity user in the database 
                var result = await _userManager.CreateAsync(user, RegData.Password);

                // tasks to do if user was created successfully
                if (result.Succeeded)
                {
                    // adding default identity user role to created user
                    await _userManager.AddToRoleAsync(user, ((ERoles)RegData.RoleId).GetDescription());

                    // create Staff bio data
                    var newStaff = new TblStaffBioData
                    {
                        AspnetUserId = user.Id,
                        StaffNumber = RegData.StaffNumber,
                        OfficeEmailAddress = RegData.Email,
                        FirstName = RegData.FirstName,
                        LastName = RegData.LastName,
                        OfficePhoneNumber = RegData.PhoneNumber,
                        CompanyId = RegData.CompanyId,
                        CreatedDate = DateTime.UtcNow
                    };

                    await _staffRepository.CreateAsync(newStaff);
                    await _staffRepository.SaveChangesAsync();

                    // Sending Confirmation Email
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var encodedToken = Encoding.UTF8.GetBytes(code);
                    var validToken = WebEncoders.Base64UrlEncode(encodedToken);

                    var callbackUrl = Url.Action("ConfirmEmail", "Account", new { UserId = user.Id, Code = validToken }, protocol: HttpContext.Request.Scheme);

                    // Send email to the user
                    string filePath = Path.Combine(Environment.CurrentDirectory, @"wwwroot/AppData", "Templates");
                    string htmlPath = $@"{filePath}/UserCreation.html";

                    var body = _emailTemplate.GetEmailTemplate(callbackUrl, htmlPath, user.Email, RegData.Password, user.FirstName);

                    await _emailSender.SendEmailAsync(user.Email, "JPSAGE.com - Confirm Your Email", body);

                    // return success message
                    return Ok(new 
                    { 
                        success = true,
                        username = user.UserName, 
                        email = user.Email, 
                        status = 1, 
                        message = "Registration Successful. Staff created successfully" 
                    });
                }
                // tasks to do if user was not created successfully
                else
                {
                    return BadRequest(new 
                    {
                        success = false,
                        message = "User registration failed",
                        errors = result.Errors.Select(x => x.Description)
                    });
                }
            }

            return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
            {
                success = false,
                message = "User registration failed",
                errors = ModelState.Error().FilterError()
            });
        }

        /// <summary>
        /// Returns a User token containing authentication details and user properties 
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="LoginData"></param>
        /// <returns></returns>
        //[ApiKeyAuth]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel LoginData)
        {
            if (ModelState.IsValid)
            {
                // Get the User from The database
                var user = await _userManager.FindByNameAsync(LoginData.Email);

                //var roles = await _userManager.GetRolesAsync(user);

                var Key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["Secret"]));

                var tokenExpiryTime = Convert.ToDouble(Configuration["ExpireTime"]);

                if (user != null && await _userManager.CheckPasswordAsync(user, LoginData.Password))
                {
                    // Then Check If Email Is confirmed
                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError(string.Empty, "User Has not Confirmed Email.");

                        return Unauthorized(new
                        {
                            LoginError = "We sent you an Confirmation Email. Please Confirm Your Registration With DGS.com To Log in."
                        });
                    }

                    // get user Role
                    var roles = await _userManager.GetRolesAsync(user);

                    // Generate Token
                    var tokenHandler = new JwtSecurityTokenHandler();

                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                       new Claim(JwtRegisteredClaimNames.Sub, LoginData.Email),
                       new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                       new Claim(ClaimTypes.NameIdentifier, user.Id),
                       //new Claim(ClaimTypes.Role, roles.FirstOrDefault()),
                       new Claim("LoggedOn", DateTime.Now.ToString()),
                        }),
                        SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256Signature),
                        Issuer = Configuration["Site"],
                        Audience = Configuration["Audience"],
                        Expires = DateTime.UtcNow.AddMinutes(tokenExpiryTime)
                    };
                    tokenDescriptor.Subject.AddClaims(roles.Select(role => new Claim(ClaimTypes.Role, role)));

                    //Generate Token
                    var token = tokenHandler.CreateToken(tokenDescriptor);

                    var userCity = "";
                    var userState = "";
                    var userCountry = "";

                    if (user.CountryId != 0)
                    {
                        var tblCountry = await _countryRepository.FirstOrDefaultAsync(x => x.CountryId == user.CountryId);
                        userCountry = tblCountry.CountryName;
                    }

                    if (user.StateId != 0)
                    {
                        var tblState = await _stateRepository.FirstOrDefaultAsync(x => x.StateId == user.StateId);
                        userState = tblState.StateName;
                    }


                    if (user.CityId != 0 && user.CityId != null)
                    {
                        var tblCity = await _cityRepository.FirstOrDefaultAsync(x => x.CityId == user.CityId);
                        userCity = tblCity.CityName;
                    }

                    return Ok(
                        new
                        {
                            token = tokenHandler.WriteToken(token),
                            expiration = token.ValidTo,
                            username = user.UserName,
                            userRoles = roles,
                            phoneNumber = user.PhoneNumber,
                            firstName = user.FirstName,
                            lastName = user.LastName,
                            otherName = user.OtherName,
                            dateOfBirth = user.DateOfBirth,
                            emailAddress = user.Email,
                            emailConfirmed = user.EmailConfirmed,
                            addressLine1 = user.AddressLine1,
                            addressLine2 = user.AddressLine2,
                            country = userCountry,
                            city = userCity,
                            state = userState,
                            profilePicture = user.ProfilePicture,
                            rating = user.Rating,
                            review = user.Review,
                            createDate = user.CreateDate

                        });
                }
            }
            // return Error
            ModelState.AddModelError("", "UserName/Password was not found sorry");
            return Unauthorized(new { LoginError = "Please Check the Login Credentials - Invalid Username/Password was Entered" });
        }

        /// <summary>
        /// Confirms a User's Email
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(code))
            {
                ModelState.AddModelError("", "User Id and Code are required");
                return BadRequest(new
                {
                    success = false,
                    message = "Email confirmation failed",
                    errors = ModelState
                });
            }

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound(new 
                { 
                    success = false,
                    message = "User not found",
                    data = new {}
                });
            }

            if (user.EmailConfirmed)
            {
                return Ok(new 
                {
                    success = true,
                    message = "User email confirmed sucessfully. Please sign in to the application.",
                    data = new {}
                });
            }

            var decodedToken = WebEncoders.Base64UrlDecode(code);
            var normalToken = Encoding.UTF8.GetString(decodedToken);

            var result = await _userManager.ConfirmEmailAsync(user, normalToken);

            if (result.Succeeded)
            {

                return RedirectToAction("EmailConfirmed", "Notifications", new { userId, normalToken });

            }
            else
            {
                List<string> errors = new List<string>();
                foreach (var error in result.Errors)
                {
                    errors.Add(error.ToString());
                }
                return BadRequest(new 
                { 
                    success = false,
                    message = "Email confirmation failed",
                    errors = errors
                });
            }
        }

        /// <summary>
        /// This api is responsible for sending password reset emails to users of the application
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="email"></param>
        /// <returns></returns>
        //[ApiKeyAuth]
        [HttpPost("restorepassword")]
        //[ValidateAntiForgeryToken]
        //[Route("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(email);

                if (user == null)
                {
                    return Ok(new 
                    {   
                        success = true,
                        message = "Please check your email to reset your password.", 
                        data = new {}
                    });
                }
                                
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var encodedToken = Encoding.UTF8.GetBytes(token);
                var validToken = WebEncoders.Base64UrlEncode(encodedToken);

                var callback = $"{Configuration["BASE_URL"]}/auth/resetPassword?email={email}&token={validToken}";

                // Send email to the user
                string filePath = Path.Combine(Environment.CurrentDirectory, @"wwwroot/AppData", "Templates");
                string htmlPath = $@"{filePath}/UserResetPassword.html";

                var body = _emailTemplate.GetEmailTemplate(callback, htmlPath, null, null, null);

                await _emailSender.SendEmailAsync(email, "JPSAGE.com - Reset password token", body);

                return Ok(new 
                {   
                    success = true,
                    message = "Please check your email to reset your password.", 
                    data = new {}
                });
            }

             return BadRequest(ModelState);
        }

        /// <summary>
        /// This resets the password of the user
        /// </summary>
        /// <param name="resetPasswordModel"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "User Id and token are required");
                return BadRequest(ModelState);
            }

            var user = await _userManager.FindByEmailAsync(resetPasswordModel.Email);

            if (user == null)
            {
                return BadRequest(new
                { 
                    success = false,
                    message = "No user associated with email" 
                });
            }

            if (resetPasswordModel.Password != resetPasswordModel.ConfirmPassword)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Password doesn't match its confirmation"
                });
            }

            var decodedToken = WebEncoders.Base64UrlDecode(resetPasswordModel.Token);
            var normalToken = Encoding.UTF8.GetString(decodedToken);

            var resetPassResult = await _userManager.ResetPasswordAsync(user, normalToken, resetPasswordModel.Password);

            if (!resetPassResult.Succeeded)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Password reset request failed",
                    errors = resetPassResult.Errors.Select(x => x.Description)
                });
            }

            return Ok(new 
            { 
                success = true,
                message = "Password was reset successfully. Please sign in to the application.", 
                data = new { }
            });
        }

        /// <summary>
        /// Endpoint to change password
        /// </summary>
        /// <param name="changePasswordDto"></param>
        /// <returns></returns>
        [HttpPost("changePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDto changePasswordDto)
        {
            try
            {
                var email = ((ClaimsIdentity)User.Identity).Claims.FirstOrDefault().Value;

                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your Non conformance report request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var user = await _userManager.FindByEmailAsync(email);

                if (user == null)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "No user associated with email",
                        data = new { }
                    });
                }

                if (changePasswordDto.NewPassword != changePasswordDto.ConfirmNewPassword)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Password doesn't match its confirmation",
                        data = new { }
                    });
                }

                var isPasswordCorrect = await _userManager.CheckPasswordAsync(user, changePasswordDto.CurrentPassword);

                if (!isPasswordCorrect)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Wrong password entered",
                        data = new { }
                    });
                }

                var result = await _userManager.ChangePasswordAsync(user, changePasswordDto.CurrentPassword, changePasswordDto.NewPassword);

                if (!result.Succeeded)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Something went wrong. Try again.",
                        error = result.Errors.Select(x => x.Description)
                    });
                }

                return Ok(new
                {
                    success = true,
                    message = "Password was changed successfully. Please sign in to the application.",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }
    }
}
