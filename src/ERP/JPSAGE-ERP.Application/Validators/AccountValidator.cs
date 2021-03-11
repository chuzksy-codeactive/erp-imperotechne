using FluentValidation;
using JPSAGE_ERP.Application.Models.Account;

namespace JPSAGE_ERP.Application.Validators
{
    public class ChangePasswordDtoValidator : AbstractValidator<ChangePasswordDto>
    {
        public ChangePasswordDtoValidator()
        {
            RuleFor(x => x.CurrentPassword)
                .NotEmpty()
                .WithMessage("Enter a valid password");
            RuleFor(x => x.NewPassword)
                .NotEmpty()
                .WithMessage("Enter a valid password");
            RuleFor(x => x.ConfirmNewPassword)
                .NotEmpty()
                .WithMessage("Enter a valid password");
        }
    }

    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Enter a valid email");
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("Enter a valid value");
            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Enter a valid value");
            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .WithMessage("Enter a valid value");
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Enter a valid value");
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty()
                .WithMessage("Enter a valid value");
            RuleFor(x => x.StaffNumber)
                .NotEmpty()
                .WithMessage("Enter a valid value");
            RuleFor(x => x.CompanyId)
                .NotEmpty()
                .WithMessage("Enter a valid value");
            RuleFor(x => x.RoleId)
                .NotEmpty()
                .WithMessage("Enter a valid value");
        }
    }
}
