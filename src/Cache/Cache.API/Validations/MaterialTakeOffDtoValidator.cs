using Cache.API.Enums;
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
            RuleFor(x => x.DisciplineId).NotEmpty();
            RuleFor(x => x.SubDisciplineId).NotEmpty();
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.ValidityPeriod).NotEmpty();
            RuleFor(x => x.ValidityStatus).NotEmpty();
            RuleFor(x => x.CompanyId).NotEmpty();
            RuleFor(x => x.ClientId).NotEmpty();
            RuleForEach(x => x.MtoCivilDetails)
                .SetValidator(new MtoCivilDetailsDtoValidator())
                .When(x => x.DisciplineId == (int)EMtoDiscipline.Civil);
            RuleForEach(x => x.MtoElectricalDetails)
                .SetValidator(new MtoElectricalDetailsDtoValidator())
                .When(x => x.DisciplineId == (int)EMtoDiscipline.Electrical);
            RuleForEach(x => x.MtoPipingDetails)
                .SetValidator(new MtoPipingDetailsDtoValidator())
                .When(x => x.DisciplineId == (int)EMtoDiscipline.Piping);
            RuleForEach(x => x.MtoInstrumentDetails)
                .SetValidator(new MtoInstrumentDetailsDtoValidator())
                .When(x => x.DisciplineId == (int)EMtoDiscipline.Instrument);
        }
    }

    public class MtoCivilDetailsDtoValidator : AbstractValidator<MtoCivilDetailsDto>
    {
        public MtoCivilDetailsDtoValidator()
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

    public class MtoElectricalDetailsDtoValidator : AbstractValidator<MtoElectricalDetailsDto>
    {
        public MtoElectricalDetailsDtoValidator()
        {
            RuleFor(x => x.ItemDescription).NotEmpty();
            RuleFor(x => x.UnitId).NotEmpty();
            RuleFor(x => x.QuantityRequired).NotEmpty();
            RuleFor(x => x.QuantitytoBuy).NotEmpty();
            RuleFor(x => x.Voltage).NotEmpty();
            RuleFor(x => x.Weight).NotEmpty();
            RuleFor(x => x.GlandSize).NotEmpty();
            RuleFor(x => x.CityId).NotEmpty();
            RuleFor(x => x.StateId).NotEmpty();
            RuleFor(x => x.CountryId).NotEmpty();
            RuleFor(x => x.UnitPrice).NotEmpty();
            RuleFor(x => x.TotalPrice).NotEmpty();
            RuleFor(x => x.Remarks).NotEmpty();
        }
    }

    public class MtoPipingDetailsDtoValidator : AbstractValidator<MtoPipingDetailsDto>
    {
        public MtoPipingDetailsDtoValidator()
        {
            RuleFor(x => x.Item).NotEmpty();
            RuleFor(x => x.Size).NotEmpty();
            RuleFor(x => x.Schedule).NotEmpty();
            RuleFor(x => x.Rating).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.ActualQuantityReq).NotEmpty();
            RuleFor(x => x.Spare).NotEmpty();
            RuleFor(x => x.TotalReq).NotEmpty();
            RuleFor(x => x.UnitId).NotEmpty();
            RuleFor(x => x.UnitPrice).NotEmpty();
            RuleFor(x => x.TotalPrice).NotEmpty();
        }
    }

    public class MtoInstrumentDetailsDtoValidator : AbstractValidator<MtoInstrumentDetailsDto>
    {
        public MtoInstrumentDetailsDtoValidator()
        {
            RuleFor(x => x.ItemDescription).NotEmpty();
            RuleFor(x => x.MaterialId).NotEmpty();
            RuleFor(x => x.Quantity).NotEmpty();
            RuleFor(x => x.MarkedUpQuantity).NotEmpty();
            RuleFor(x => x.UnitToOrder).NotEmpty();
            RuleFor(x => x.UnitId).NotEmpty();
            RuleFor(x => x.ManufacturerId).NotEmpty();
            RuleFor(x => x.ModelNumber).NotEmpty();
            RuleFor(x => x.Comments).NotEmpty();
            RuleFor(x => x.QuantityRequired).NotEmpty();
            RuleFor(x => x.QuantitytoBuy).NotEmpty();
            RuleFor(x => x.Remarks).NotEmpty();
        }
    }

    public class MtoDisciplineDetailDtoValidator : AbstractValidator<MtoDisciplineDetailDto>
    {
        public MtoDisciplineDetailDtoValidator()
        {
            RuleFor(x => x.MtoCivilDetail)
                .NotNull()
                .SetValidator(new MtoCivilDetailsDtoValidator())
                .When(x => x.MtoCivilDetail != null);
            RuleFor(x => x.MtoElectricalDetail)
                .NotNull()
                .SetValidator(new MtoElectricalDetailsDtoValidator())
                .When(x => x.MtoElectricalDetail != null);
            RuleFor(x => x.MtoInstrumentDetail)
                .NotNull()
                .SetValidator(new MtoInstrumentDetailsDtoValidator())
                .When(x => x.MtoInstrumentDetail != null);
            RuleFor(x => x.MtoPipingDetail)
                .NotNull()
                .SetValidator(new MtoPipingDetailsDtoValidator())
                .When(x => x.MtoPipingDetail != null);
        }
    }

    public class MtoDisciplineDetailsDtoValidaor : AbstractValidator<MtoDisciplineDetailsDto>
    {
        public MtoDisciplineDetailsDtoValidaor()
        {
            RuleFor(x => x.MtoCivilDetails)
                .NotEmpty().NotNull()
                .ForEach(x => x.SetValidator(new MtoCivilDetailsDtoValidator()))
                .When(x => x.MtoCivilDetails.Count > 0);
            RuleFor(x => x.MtoElectricalDetails)
                .NotEmpty().NotNull()
                .ForEach(x => x.SetValidator(new MtoElectricalDetailsDtoValidator()))
                .When(x => x.MtoElectricalDetails.Count > 0);
            RuleFor(x => x.MtoInstrumentDetails)
                .NotEmpty().NotNull()
                .ForEach(x => x.SetValidator(new MtoInstrumentDetailsDtoValidator()))
                .When(x => x.MtoInstrumentDetails.Count > 0);
            RuleFor(x => x.MtoPipingDetails)
                .NotEmpty().NotNull()
                .ForEach(x => x.SetValidator(new MtoPipingDetailsDtoValidator()))
                .When(x => x.MtoPipingDetails.Count > 0);
        }
    }
}
