using FluentValidation;
using JPSAGE_ERP.Application.Models.SiteReporting;
using System;

namespace JPSAGE_ERP.Application.Validators
{
    public class NonConformanceReportDtoValidator : AbstractValidator<NonConformanceReporFormtDto>
    {
        public NonConformanceReportDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.CountryId).NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.StateId).NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.CityId).NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.SystemsSubSystems).NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.SupplierId).NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.ReqEngApproval).NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.DocumentReqViolated).NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.ResponseDate).NotEmpty().WithMessage("Enter a valid date");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Enter a valid date");
            RuleFor(x => x.NcrAttachments).SetValidator(new NcrAttachmentDtoValidator());
        }
    }

    public class NcrAttachmentDtoValidator : AbstractValidator<NcrAttachmentDto>
    {
        public NcrAttachmentDtoValidator()
        {
            RuleForEach(x => x.DrawingFile)
               .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
               .WithMessage("Enter a valid url link")
               .When(x => x.DrawingFile.Length > 0);
            RuleForEach(x => x.NCRImages)
               .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
               .WithMessage("Enter a valid url link")
               .When(x => x.NCRImages.Length > 0);
            RuleForEach(x => x.DescriptionDocuments)
               .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
               .WithMessage("Enter a valid url link")
               .When(x => x.DescriptionDocuments.Length > 0);
        }
    }
}
