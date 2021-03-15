using AutoMapper;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models.Account;
using JPSAGE_ERP.Application.Models.Miscellaneous;
using JPSAGE_ERP.Application.Models.Projects;
using JPSAGE_ERP.Application.Models.Responses;
using JPSAGE_ERP.Application.Services;
using JPSAGE_ERP.Domain;
using JPSAGE_ERP.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JPSAGE_ERP.WebAPI.Controllers
{
    /// <summary>
    /// This controller is just used to handle all
    /// gets resources for dropdowns on the UI
    /// </summary>
    /// [Route("api/v1/sitereports")]
    [Route("api/v1/miscellaneous")]
    [Authorize]
    [ApiController]
    public class MiscellaneousController : ControllerBase
    {
        private readonly IRepository<TblCountry> _tblCountry;
        private readonly IRepository<TblCompanyInfo> _tblCompany;
        private readonly IRepository<TblState> _tblState;
        private readonly IRepository<TblCity> _tblCity;
        private readonly IRepository<TblStaffBioData> _tblStaffBioData;
        private readonly IRepository<TblSupplierIdentification> _tblSupplierIdentification;
        private readonly ISiteReportRepository _siteReportRepository;
        private readonly IMapper _mapper;
        private readonly IRepository<TblStaffBioData> _staffRepository;
        private readonly IFileContentUploadService _fileContentUploadedService;
        private readonly IRepository<TblProjects> _tblProjects;
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Constructor Dependency Injections
        /// </summary>
        /// <param name="tblCountry"></param>
        /// <param name="tblState"></param>
        /// <param name="tblCity"></param>
        /// <param name="tblStaffBioData"></param>
        /// <param name="tblSupplierIdentification"></param>
        /// <param name="mapper"></param>
        public MiscellaneousController(
            IRepository<TblCountry> tblCountry,
            IRepository<TblCompanyInfo> tblCompany,
            IRepository<TblState> tblState,
            IRepository<TblCity> tblCity,
            IRepository<TblStaffBioData> tblStaffBioData,
            IRepository<TblSupplierIdentification> tblSupplierIdentification,
            ISiteReportRepository siteReportRepository,
            IRepository<TblStaffBioData> staffRepository,
            IFileContentUploadService fileContentUploadedService,
            IMapper mapper, IRepository<TblProjects> tblProjects, ApplicationDbContext context)
        {
            _tblCountry = tblCountry;
            _tblCompany = tblCompany;
            _tblState = tblState;
            _tblCity = tblCity;
            _tblStaffBioData = tblStaffBioData;
            _tblSupplierIdentification = tblSupplierIdentification;
            _siteReportRepository = siteReportRepository;
            _mapper = mapper;
            _staffRepository = staffRepository;
            _fileContentUploadedService = fileContentUploadedService;
            _tblProjects = tblProjects;
            _context = context;
        }

        /// <summary>
        /// This method returns the user Id
        /// </summary>
        /// <returns name="string">string</returns>
        [NonAction]
        public string GetUserId()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.Claims.Skip(1).FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);


            var userId = claim.Value;
            return userId;
        }

        /// <summary>
        /// Use to fetch all countries
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCountry")]
        public async Task<IActionResult> GetAllCountry()
        {
            var result = await _tblCountry.GetAllAsync();

            var countries = _mapper.Map<IEnumerable<CountryDto>>(result);

            return Ok(new SucessResponse<IEnumerable<CountryDto>>
            {
                success = true,
                message = "Countries retrieved successfully",
                data = countries
            });
        }

        [HttpGet("GetAllProjects")]
        [ProducesResponseType(typeof(SucessResponse<IEnumerable<ProjectsDto>>), 200)]
        public async Task<IActionResult> GetProjects([FromQuery] string search)
        {
            try
            {
                var projects = new List<TblProjects>();

                if (!string.IsNullOrEmpty(search.Trim()))
                {
                    projects = await _context.TblProjects.Where(x => x.ProjectName.ToLower().Contains(search.Trim().ToLower())).ToListAsync();
                }
                else
                {
                    projects = await _context.TblProjects.ToListAsync();
                }

                var projectsDto = _mapper.Map<IEnumerable<ProjectsDto>>(projects);

                return Ok(new SucessResponse<IEnumerable<ProjectsDto>>
                {
                    success = true,
                    message = "Projects retrieved successfully",
                    data = projectsDto
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        [HttpGet("GetAllClients")]
        [ProducesResponseType(typeof(SucessResponse<IEnumerable<ClientDto>>), 200)]
        public async Task<IActionResult> GetClients([FromQuery] string search)
        {
            try
            {
                var clients = new List<TblClients>();

                if (!string.IsNullOrEmpty(search))
                {
                    clients = await _context.TblClients.Where(x => x.ClientName.ToLower().Contains(search.ToLower())).ToListAsync();
                }
                else
                {
                    clients = await _context.TblClients.ToListAsync();
                }

                var clientsDto = _mapper.Map<IEnumerable<ClientDto>>(clients);

                return Ok(new SucessResponse<IEnumerable<ClientDto>>
                {
                    success = true,
                    message = "Clients retrieved successfully",
                    data = clientsDto
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        [HttpGet("GetAllUnits")]
        [ProducesResponseType(typeof(SucessResponse<IEnumerable<UnitDto>>), 200)]
        public async Task<IActionResult> GetUnits([FromQuery] string search)
        {
            try
            {
                var units = new List<TblUnits>();

                if (!string.IsNullOrEmpty(search))
                {
                    units = await _context.TblUnits.Where(x => x.UnitName.ToLower().Contains(search.ToLower())).ToListAsync();
                }
                else
                {
                    units = await _context.TblUnits.ToListAsync();
                }

                var unitsDto = _mapper.Map<IEnumerable<UnitDto>>(units);

                return Ok(new SucessResponse<IEnumerable<UnitDto>>
                {
                    success = true,
                    message = "Units retrieved successfully",
                    data = unitsDto
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        [HttpGet("GetAllCurrencys")]
        [ProducesResponseType(typeof(SucessResponse<IEnumerable<CurrencyDto>>), 200)]
        public async Task<IActionResult> GetCurrencys([FromQuery] string search)
        {
            try
            {
                var currency = new List<TblCurrency>();

                if (!string.IsNullOrEmpty(search))
                {
                    currency = await _context.TblCurrency.Where(x => x.CurrencyName.ToLower().Contains(search.ToLower())).ToListAsync();
                }
                else
                {
                    currency = await _context.TblCurrency.ToListAsync();
                }

                var currencysDto = _mapper.Map<IEnumerable<CurrencyDto>>(currency);

                return Ok(new SucessResponse<IEnumerable<CurrencyDto>>
                {
                    success = true,
                    message = "Currency retrieved successfully",
                    data = currencysDto
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// Used to fetch all states
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllState")]
        public async Task<IActionResult> GetAllState()
        {
            var result = await _tblState.GetAllAsync();

            var states = _mapper.Map<IEnumerable<StateDto>>(result);

            return Ok(new SucessResponse<IEnumerable<StateDto>>
            {
                success = true,
                message = "States retrieved successfully",
                data = states
            });
        }

        /// <summary>
        /// Used to fetch all states for a country
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetStates/{countryId}")]
        public async Task<IActionResult> GetAllStateForCountry(int countryId)
        {
            var result = await _context.TblState.Where(x => x.CountryId == countryId).ToListAsync();

            var states = _mapper.Map<IEnumerable<StateDto>>(result);

            return Ok(new SucessResponse<IEnumerable<StateDto>>
            {
                success = true,
                message = "States retrieved successfully",
                data = states
            });
        }

        /// <summary>
        /// Used to fetch all cities
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCity")]
        public async Task<IActionResult> GetAllCity()
        {
            var result = await _tblCity.GetAllAsync();

            var cities = _mapper.Map<IEnumerable<CityDto>>(result);

            return Ok(new SucessResponse<IEnumerable<CityDto>>
            {
                success = true,
                message = "Cities retrieved successfully",
                data = cities
            });
        }

        /// <summary>
        /// Used to fetch all cities for a state
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCity/{stateId}")]
        public async Task<IActionResult> GetAllCityForState(int stateId)
        {
            var result = await _context.TblCity.Where(x => x.StateId == stateId).ToListAsync();

            var cities = _mapper.Map<IEnumerable<CityDto>>(result);

            return Ok(new SucessResponse<IEnumerable<CityDto>>
            {
                success = true,
                message = "Cities retrieved successfully",
                data = cities
            });
        }

        /// <summary>
        /// Used to fetch all staff
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllStaff")]
        public async Task<IActionResult> GetAllStaff()
        {
            var result = await _tblStaffBioData.GetAllAsync();

            var staff = _mapper.Map<IEnumerable<StaffDto>>(result);

            return Ok(new SucessResponse<IEnumerable<StaffDto>>
            {
                success = true,
                message = "Staffs retrieved successfully",
                data = staff
            });
        }

        /// <summary>
        /// Used to fetch all staff
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllSupplier")]
        public async Task<IActionResult> GetAllSupplier()
        {
            var result = await _tblSupplierIdentification.GetAllAsync();

            var supplier = _mapper.Map<IEnumerable<SupplierDto>>(result);

            return Ok(new SucessResponse<IEnumerable<SupplierDto>>
            {
                success = true,
                message = "Suppliers retrieved successfully",
                data = supplier
            });
        }

        /// <summary>
        /// Used to fetch all Company info from the table
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCompanyQueries")]
        public async Task<IActionResult> GetAllCompanies([FromQuery] string search)
        {
            var result = await _siteReportRepository.GetAllCompanyInfo(search);

            return Ok(new SucessResponse<IEnumerable<CompanyInfoDto>>
            {
                success = true,
                message = "Company Info retrieved successfully",
                data = result
            });
        }

        /// <summary>
        /// Used to fetch all CTQId from the 
        /// TSrconstructionTechnicalQueriesTemp table
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllSRCTechnicalQueries")]
        public async Task<IActionResult> GetAllSRCTechnicalQueries()
        {
            var result = await _siteReportRepository.GetAllSRCTQReplies();

            return Ok(new SucessResponse<IEnumerable<TSrconstructionTechnicalQueriesTempDto>>
            {
                success = true,
                message = "CTQIDs retrieved successfully",
                data = result
            });
        }

        /// <summary>
        /// The endpoint is used to return all CTQIDs created by the Attention
        /// And it only return all CTQIDs that are not approved yet
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllSRCTQForAttendee")]
        public async Task<IActionResult> GetAllSRCTQForAttendee()
        {
            var userId = GetUserId();
            var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

            var result = await _siteReportRepository.GetAllSRCTQRepliesForAttentee(tblStaff.StaffId);

            return Ok(new SucessResponse<IEnumerable<TSrconstructionTechnicalQueriesTempDto>>
            {
                success = true,
                message = "CTQIDs retrieved successfully",
                data = result
            });
        }

        /// <summary>
        /// The endpoint is used to return all CTQIDs created by the Initiator
        /// And it only return all CTQIDs that are not approved yet
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllSRCTQForInitiator")]
        public async Task<IActionResult> GetAllSRCTQForInitiator()
        {
            var userId = GetUserId();
            var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

            var result = await _siteReportRepository.GetAllSRCTQRepliesForInitiator(tblStaff.StaffId);

            return Ok(new SucessResponse<IEnumerable<TSrconstructionTechnicalQueriesTempDto>>
            {
                success = true,
                message = "CTQIDs retrieved successfully",
                data = result
            });
        }

        /// <summary>
        /// The endpoint is used to upload a single file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost("PostFileContent")]
        public async Task<IActionResult> PostSingleFileContent(IFormFile file)
        {
            var result = await _fileContentUploadedService.SingleFileUpload(file);

            if (!result.Success)
            {
                return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                {
                    success = false,
                    message = "Uploading file content failed",
                    errors = new Dictionary<string, string[]>
                    {
                        { file.FileName, new string[] {result.Message} }
                    }
                });
            }

            return Ok(new SucessResponse<object>
            {
                success = true,
                message = "Content file uploaded successfully",
                data = result.Url
            });
        }

        /// <summary>
        /// The endpoint is used to upload a multiple file
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost("PostMultipleFileContent")]
        public async Task<IActionResult> PostMultipleFileContent(IFormFileCollection files)
        {
            var result = await _fileContentUploadedService.MultipleFileUpload(files);

            if (!result.Success)
            {
                return BadRequest(new ErrorResponse<Dictionary<string, string>>
                {
                    success = false,
                    message = "Uploading file content failed",
                    errors = result.Messages
                });
            }

            return Ok(new SucessResponse<object>
            {
                success = true,
                message = "Content file uploaded successfully",
                data = result.Urls
            });
        }

        /// <summary>
        /// Endpoint to get all roles
        /// </summary>
        /// <returns></returns>
        [HttpGet("getRoles")]
        public IActionResult GetAllRoles()
        {
            var roles = new List<UserRoleDto>
            {
                new UserRoleDto { Id = "1", Name = "Admin" },
                new UserRoleDto { Id = "2", Name = "Checker" },
                new UserRoleDto { Id = "3", Name = "Authorizer" },
                new UserRoleDto { Id = "4", Name = "Staff" },
                new UserRoleDto { Id = "5", Name = "VendorAdmin" },
                new UserRoleDto { Id = "6", Name = "Vendor" }
            };

            return Ok(new SucessResponse<IEnumerable<UserRoleDto>>
            {
                success = true,
                message = "Roles retrieved successfully",
                data = roles
            });
        }
    }
}
