using FluentValidation;
using JPSAGE_ERP.Application.Models.SiteReporting;

namespace JPSAGE_ERP.Application.Validators
{
    public class DailyReportFormDTOValidator : AbstractValidator<DailyReportFormDTO>
    {
        public DailyReportFormDTOValidator()
        {
            RuleFor(x => x.ProjectId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.GeneralSummary)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.ConstructionActivities)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.DailyProgress)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.FollowingDayPlan)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.ProgressAt)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.ConstructionActual)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.Planned)
                .NotEmpty().WithMessage("Enter a valid value");
        }
    }

    public class SrdrGeneralSummaryDtoValidator : AbstractValidator<SrdrGeneralSummaryDto>
    {
        public SrdrGeneralSummaryDtoValidator()
        {
            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.ProjectId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.GeneralSummary)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.OtherAttachment)
               .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
               .WithMessage("Enter a valid url link");
        }
    }

    public class SrdrHseReprotDtoValidator : AbstractValidator<SrdrHSEReportDto>
    {
        public SrdrHseReprotDtoValidator()
        {
            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.ProjectId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.DetailsStatistics)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.Remarks)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Enter a valid value");
        }
    }

    public class SrdrHseAttachmentDtoValidator : AbstractValidator<SrdrHSEAttachmentDto>
    {
        public SrdrHseAttachmentDtoValidator()
        {
            RuleFor(x => x.PermitToWork)
               .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
               .WithMessage("Enter a valid url link");
            RuleFor(x => x.SecurityReport)
               .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
               .WithMessage("Enter a valid url link");
        }
    }

    public class SrdrConstructionActivitiesDtoValidator : AbstractValidator<SrdrConstructionActivitiesDto>
    {
        public SrdrConstructionActivitiesDtoValidator()
        {
            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.ProjectId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.ConstructionActivities)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.DailyProgress)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.FollowingDayPlan)
                .NotEmpty().WithMessage("Enter a valid value");
        }
    }

    public class SrdrProgressMeasurementDtoValidator : AbstractValidator<SrdrProgressMeasurementDto>
    {
        public SrdrProgressMeasurementDtoValidator()
        {
            RuleFor(x => x.Activity)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.CumPlannedProgress)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.CumProgressActual)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.Remarks)
                .NotEmpty().WithMessage("Enter a valid value");
        }
    }
    public class SrdrIssueDtoValidator : AbstractValidator<SrdrIssueDto>
    {
        public SrdrIssueDtoValidator()
        {
            RuleFor(x => x.Challenges)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.Recommendations)
                .NotEmpty().WithMessage("Enter a valid value");
        }
    }

    public class SrdrDelayDtoValidator : AbstractValidator<SrdrDelayDto>
    {
        public SrdrDelayDtoValidator()
        {
            RuleFor(x => x.DescriptionofDelay)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.Cause)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.Responsible)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.TimeTakenFrom)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.TimeTakenTo)
                .NotEmpty().WithMessage("Enter a valid value");
        }
    }

    public class SrdrProMeMasterDtoValidator : AbstractValidator<SrdrProMeMasterDto>
    {
        public SrdrProMeMasterDtoValidator()
        {
            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.ProjectId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.ProgressAt)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.ConstructionActual)
                .NotEmpty().WithMessage("Enter a valid value");
            RuleFor(x => x.Planned)
                .NotEmpty().WithMessage("Enter a valid value");
        }
    }

    public class SrdrProgresssPicturesDtoValidator : AbstractValidator<SrdrProgresssPicturesDto>
    {
        public SrdrProgresssPicturesDtoValidator()
        {
            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.ProjectId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleForEach(x => x.ProgressPictures)
                .NotEmpty()
                .NotNull()
                .SetValidator(x => new ProgressPictureDtoValidator());
        }
    }

    public class ProgressPictureDtoValidator : AbstractValidator<ProgressPictureDto>
    {
        public ProgressPictureDtoValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Enter a valid value")
                .When(x => !string.IsNullOrEmpty(x.Description));
            RuleFor(x => x.ProgressPictures)
              .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
              .WithMessage("Enter a valid url link")
              .When(x => !string.IsNullOrEmpty(x.ProgressPictures));
        }
    }

    public class SrdrOtherSiteReportDtoValidator : AbstractValidator<SrdrOtherSiteReportDto>
    {
        public SrdrOtherSiteReportDtoValidator()
        {
            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.ProjectId)
                .NotEmpty().WithMessage("Enter a valid value")
                .GreaterThan(0).WithMessage("ProjectId must be an integer");
            RuleFor(x => x.Qaqcreport)
              .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
              .WithMessage("Enter a valid url link")
              .When(x => !string.IsNullOrEmpty(x.Qaqcreport));
            RuleFor(x => x.LogisticsReport)
              .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
              .WithMessage("Enter a valid url link")
              .When(x => !string.IsNullOrEmpty(x.LogisticsReport));
            RuleFor(x => x.SitePersonnelLogReport)
              .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
              .WithMessage("Enter a valid url link")
              .When(x => !string.IsNullOrEmpty(x.SitePersonnelLogReport));
            RuleFor(x => x.MaterialReport)
              .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
              .WithMessage("Enter a valid url link")
              .When(x => !string.IsNullOrEmpty(x.MaterialReport));
            RuleFor(x => x.Mocreport)
              .NotEmpty().Matches(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$")
              .WithMessage("Enter a valid url link")
              .When(x => !string.IsNullOrEmpty(x.Mocreport));
        }
    }

    public class SrdrHseReportAttachmentDtoValidator : AbstractValidator<SrdrHseReportAttachmentDto>
    {
        public SrdrHseReportAttachmentDtoValidator()
        {
            RuleForEach(x => x.SrdrHSEReports)
                .NotNull()
                .NotEmpty()
                .SetValidator(x => new SrdrHseReprotDtoValidator());
            RuleFor(x => x.SrdrHseReportAttachment)
                .NotNull()
                .SetValidator(x => new SrdrHseAttachmentDtoValidator());
        }
    }

    public class SrDailyMeasurmentScoreSheetDtoValidator : AbstractValidator<SrDailyMeasurmentScoreDto>
    {
        public SrDailyMeasurmentScoreSheetDtoValidator()
        {
            RuleForEach(x => x.SrdrProgressMeasurements)
                .NotNull()
                .NotEmpty()
                .SetValidator(x => new SrdrProgressMeasurementDtoValidator());
            RuleForEach(x => x.SrdrDelays)
                .NotNull()
                .NotEmpty()
                .SetValidator(x => new SrdrDelayDtoValidator());
            RuleForEach(x => x.SrdrIssues)
                .NotNull()
                .NotEmpty()
                .SetValidator(x => new SrdrIssueDtoValidator());
            RuleFor(x => x.SrdrProMeMaster)
                .NotNull()
                .SetValidator(x => new SrdrProMeMasterDtoValidator());
        }
    }
}
