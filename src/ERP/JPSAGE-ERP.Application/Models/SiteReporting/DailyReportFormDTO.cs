using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Application.Models.SiteReporting
{
    public class DailyReportFormDTO
    {
        public DailyReportFormDTO()
        {
            HSEReport = new HashSet<HSEReportDTO>() { new HSEReportDTO() };
            DailyReportingProgressMeasurement = new HashSet<DailyReportingProgressMeasurementDTO>() { new DailyReportingProgressMeasurementDTO() };
            DailyReportingIssues = new HashSet<DailyReportingIssuesDTO>() { new DailyReportingIssuesDTO() };
            DailyReportingDelays = new HashSet<DailyReportingDelaysDTO>() { new DailyReportingDelaysDTO() };
        }
        public int ProjectId { get; set; }
        public string GeneralSummary { get; set; }
        public string ConstructionActivities { get; set; }
        public string DailyProgress { get; set; }
        public string FollowingDayPlan { get; set; }
        public string ProgressAt { get; set; }
        public decimal ConstructionActual { get; set; }
        public decimal Planned { get; set; }
        public ICollection<HSEReportDTO> HSEReport { get; set; }
        public ICollection<DailyReportingProgressMeasurementDTO> DailyReportingProgressMeasurement { get; set; }
        public ICollection<DailyReportingIssuesDTO> DailyReportingIssues { get; set; }
        public ICollection<DailyReportingDelaysDTO> DailyReportingDelays { get; set; }
        public DailyReportingFileAttachmentsDTO DailyReportingFileAttachments { get; set; }
    }
    
    public class SrdrGeneralSummaryDto
    {
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }
        public string GeneralSummary { get; set; }
        public string OtherAttachment { get; set; }
    }

    public class SrdrHSEReportDto
    {
        public string Title { get; set; }
        public string DetailsStatistics { get; set; }
        public string Remarks { get; set; }
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }
    }

    public class SrdrHSEAttachmentDto
    {
        public string PermitToWork { get; set; }
        public string SecurityReport { get; set; }
    }

    public class SrdrHseReportAttachmentDto
    {
        public SrdrHseReportAttachmentDto()
        {
            SrdrHSEReports = new HashSet<SrdrHSEReportDto>();
        }

        public ICollection<SrdrHSEReportDto> SrdrHSEReports { get; set; }
        public SrdrHSEAttachmentDto SrdrHseReportAttachment { get; set; }
    }

    public class SrdrConstructionActivitiesDto
    {
        public int ProjectId { get; set; }
        public int CompanyId { get; set; }
        public string ConstructionActivities { get; set; }
        public string DailyProgress { get; set; }
        public string FollowingDayPlan { get; set; }
    }

    public class SrdrProgressMeasurementDto
    {
        public string Activity { get; set; }
        public decimal CumProgressActual { get; set; }
        public decimal CumPlannedProgress { get; set; }
        public string Remarks { get; set; }
    }

    public class SrdrIssueDto
    {
        public string Challenges { get; set; }
        public string Recommendations { get; set; }
    }

    public class SrdrDelayDto
    {
        public string DescriptionofDelay { get; set; }
        public string Cause { get; set; }
        public int? Responsible { get; set; }
        public DateTime? TimeTakenFrom { get; set; }
        public DateTime? TimeTakenTo { get; set; }
    }
    
    public class SrdrProMeMasterDto
    {
        public int ProjectId { get; set; }
        public int CompanyId { get; set; }
        public string ProgressAt { get; set; }
        public decimal ConstructionActual { get; set; }
        public decimal Planned { get; set; }
    }

    public class SrDailyMeasurmentScoreDto
    {
        public SrDailyMeasurmentScoreDto()
        {
            SrdrProgressMeasurements = new HashSet<SrdrProgressMeasurementDto>();
            SrdrIssues = new HashSet<SrdrIssueDto>();
            SrdrDelays = new HashSet<SrdrDelayDto>();
        }

        public SrdrProMeMasterDto SrdrProMeMaster { get; set; }
        public ICollection<SrdrProgressMeasurementDto> SrdrProgressMeasurements { get; set; }
        public ICollection<SrdrIssueDto> SrdrIssues { get; set; }
        public ICollection<SrdrDelayDto> SrdrDelays { get; set; }
    }

    public class SrdrProgresssPicturesDto
    {
        public SrdrProgresssPicturesDto()
        {
            ProgressPictures = new HashSet<ProgressPictureDto>();
        }

        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }
        public string Description { get; set; }
        public ICollection<ProgressPictureDto> ProgressPictures { get; set; }
    }

    public class ProgressPictureDto
    {
        public string Description { get; set; }
        public string ProgressPictures { get; set; }
    }

    public class SrdrOtherSiteReportDto
    {
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }
        public string Qaqcreport { get; set; }
        public string LogisticsReport { get; set; }
        public string SitePersonnelLogReport { get; set; }
        public string MaterialReport { get; set; }
        public string Mocreport { get; set; }
    }

    public class HSEReportDTO
    {
        public string Title { get; set; }
        public string DetailStatistics { get; set; }
        public string Remarks { get; set; }
    }

    public class DailyReportingProgressMeasurementDTO
    {
        public string Activity { get; set; }
        public decimal? CumProgressActual { get; set; }
        public decimal? CumPlannedProgress { get; set; }
        public string Remarks { get; set; }
    }

    public class DailyReportingIssuesDTO
    {
        public string Challenges { get; set; }
        public string Recommendations { get; set; }
    }

    public class DailyReportingDelaysDTO
    {
        public string DescriptionOfDelay { get; set; }
        public DateTime? TimeTaken { get; set; }
        public string Cause { get; set; }
        public string Responsible { get; set; }
    }

    public class DailyReportingFileAttachmentsDTO
    {
        public IFormFileCollection PermitToWork { get; set; }
        public IFormFileCollection SecurityReport { get; set; }
        public IFormFileCollection ProgressPictures { get; set; }
        public IFormFileCollection Qaqcreport { get; set; }
        public IFormFileCollection LogisticsReport { get; set; }
        public IFormFileCollection SitePersonnelLogReport { get; set; }
        public IFormFileCollection MaterialReport { get; set; }
        public IFormFileCollection Mocreport { get; set; }
    }
}
