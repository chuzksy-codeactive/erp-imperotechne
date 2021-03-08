using System;

namespace JPSAGE_ERP.Application.Models.SiteReporting
{
    public class AuthListDto
    {
        public int AuthId { get; set; }
        public string Title { get; set; }
        public string EventType { get; set; }
        public string Status { get; set; }
        public string Company { get; set; }
        public DateTime CreatedDate { get; set; }
        public int WfDefId { get; set; }
    }

    public class AuthListDetailsDto
    {
        public int AuthId { get; set; }
        public string Title { get; set; }
        public string EventType { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string StatusReason { get; set; }
        public string CheckerStatus { get; set; }
        public string CheckerStatusReason { get; set; }
        public string ApproverStatus { get; set; }
        public string ApproverStatusReason { get; set; }
        public int CheckerId { get; set; }
        public int ApproverId { get; set; }
        public string Checker { get; set; }
        public string Approver { get; set; }
    }

    public class GeneralSummaryDetailDto
    {
        public int GenSumId { get; set; }
        public string GeneralSummary { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DocumentNumber { get; set; }
        public string Company { get; set; }
        public string Project { get; set; }
        public AuthListDetailsDto AuthListDetail { get; set; }
    }

    public class HseDetailDto
    {
        public int DrhseattId { get; set; }
        public string PermitToWork { get; set; }
        public string SecurityReport { get; set; }
        public DateTime? CreatedDate { get; set; }
        public AuthListDetailsDto AuthListDetail { get; set; }
    }

    public class OtherSiteDetialDto
    {
        public int OsrepId { get; set; }
        public string Qaqcreport { get; set; }
        public string LogisticsReport { get; set; }
        public string SitePersonnelLogReport { get; set; }
        public string MaterialReport { get; set; }
        public string Mocreport { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DocumentNumber { get; set; }
        public string Company { get; set; }
        public string Project { get; set; }
        public AuthListDetailsDto AuthListDetail { get; set; }
    }

    public class ProgressPicturesDetailDto
    {
        public int Ppid { get; set; }
        public string ProgressPictures { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DocumentNumber { get; set; }
        public string Company { get; set; }
        public string Project { get; set; }
        public AuthListDetailsDto AuthListDetail { get; set; }
    }

    public class ConstructionTechnicalDetailDto
    {
        public int Ctqid { get; set; }
        public string Ctqtitle { get; set; }
        public string Ctqnumber { get; set; }
        public DateTime QueryDate { get; set; }
        public string Ctqdescription { get; set; }
        public int? Attention { get; set; }
        public string Project { get; set; }
        public AuthListDetailsDto AuthListDetail { get; set; }
    }

    public class NonConformanceDetailDto
    {
        public int Ncrid { get; set; }
        public string Title { get; set; }
        public string ReportNumber { get; set; }
        public string Item { get; set; }
        public string SystemsSubSystems { get; set; }
        public string Supplier { get; set; }
        public bool? ReqEngApproval { get; set; }
        public string IssuedBy { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string Description { get; set; }
        public string DocumentNumber { get; set; }
        public string Project { get; set; }
        public AuthListDetailsDto AuthListDetail { get; set; }
    }

    public class ConstructionActivityDetailDto
    {
        public int DrconActId { get; set; }
        public string ConstructionActivities { get; set; }
        public string DailyProgress { get; set; }
        public string FollowingDayPlan { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DocumentNumber { get; set; }
        public string Company { get; set; }
        public string Project { get; set; }
        public AuthListDetailsDto AuthListDetail { get; set; }
    }

    public class DailyPGMeasurmentDetailDto
    {
        public int ProMeMasterId { get; set; }
        public string ProgressAt { get; set; }
        public decimal? ConstructionActual { get; set; }
        public decimal? Planned { get; set; }
        public string DocumentNumber { get; set; }
        public string Company { get; set; }
        public string Project { get; set; }
        public AuthListDetailsDto AuthListDetail { get; set; }
    }
}
