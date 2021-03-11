using Cache.API.Model;
using FluentValidation;

namespace Cache.API.Validations
{
    public class MaterialTakeOffDtoValidator : AbstractValidator<MaterialTakeOffDto>
    {
        public MaterialTakeOffDtoValidator()
        {
            RuleFor(x => x.UserEmail).NotEmpty();
            RuleFor(x => x.ProjectId).NotEmpty();
            RuleFor(x => x.MtodisciplineId).NotEmpty();
            RuleFor(x => x.MtosubDisciplineId).NotEmpty();
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.ValidityPeriod).NotEmpty();
            RuleFor(x => x.ValidityStatus).NotEmpty();
            RuleFor(x => x.CompanyId).NotEmpty();
            RuleFor(x => x.ClientId).NotEmpty();
            RuleFor(x => x.CreatedBy).NotEmpty();
            RuleForEach(x => x.MaterialTakeOffDetails)
                .SetValidator(new MaterialTakeOffDetailDtoValidator())
                .When(x => x.MaterialTakeOffDetails.Count > 0);
        }
    }

    public class MaterialTakeOffDetailDtoValidator : AbstractValidator<MaterialTakeOffDetailDto>
    {
        public MaterialTakeOffDetailDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Quantity).NotEmpty();
            RuleFor(x => x.Rate).NotEmpty();
            RuleFor(x => x.UnitId).NotEmpty();
            RuleFor(x => x.Amount).NotEmpty();
            RuleFor(x => x.Subtotal).NotEmpty();
            RuleFor(x => x.Total).NotEmpty();
        }
    }
}
