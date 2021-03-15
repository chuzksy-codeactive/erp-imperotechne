using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblCompanyInfo
    {
        public TblCompanyInfo()
        {
            TblClients = new HashSet<TblClients>();
            TblCompanySubContractors = new HashSet<TblCompanySubContractors>();
            TblDepartments = new HashSet<TblDepartments>();
            TblEndUserRequisitionServices = new HashSet<TblEndUserRequisitionServices>();
            TblInvoice = new HashSet<TblInvoice>();
            TblJobCompletionCertificate = new HashSet<TblJobCompletionCertificate>();
            TblMtoforms = new HashSet<TblMtoforms>();
            TblMtoformsTemp = new HashSet<TblMtoformsTemp>();
            TblPurchaseOrder = new HashSet<TblPurchaseOrder>();
            TblSrconstructionTechnicalQueries = new HashSet<TblSrconstructionTechnicalQueries>();
            TblSrconstructionTechnicalQueriesTemp = new HashSet<TblSrconstructionTechnicalQueriesTemp>();
            TblSrdailyReportHse = new HashSet<TblSrdailyReportHse>();
            TblSrdailyReportHsetemp = new HashSet<TblSrdailyReportHsetemp>();
            TblSrdailyReportOtherSiteReports = new HashSet<TblSrdailyReportOtherSiteReports>();
            TblSrdailyReportOtherSiteReportsTemp = new HashSet<TblSrdailyReportOtherSiteReportsTemp>();
            TblSrdailyReportProgressMeasurementMaster = new HashSet<TblSrdailyReportProgressMeasurementMaster>();
            TblSrdailyReportProgressMeasurementMasterTemp = new HashSet<TblSrdailyReportProgressMeasurementMasterTemp>();
            TblSrdailyReportingConstructionActivities = new HashSet<TblSrdailyReportingConstructionActivities>();
            TblSrdailyReportingConstructionActivitiesTemp = new HashSet<TblSrdailyReportingConstructionActivitiesTemp>();
            TblSrdailyReportingGeneralSummary = new HashSet<TblSrdailyReportingGeneralSummary>();
            TblSrdailyReportingGeneralSummaryTemp = new HashSet<TblSrdailyReportingGeneralSummaryTemp>();
            TblSrdailyReportingProgressPictures = new HashSet<TblSrdailyReportingProgressPictures>();
            TblSrdailyReportingProgressPicturesTemp = new HashSet<TblSrdailyReportingProgressPicturesTemp>();
            TblStaffBioData = new HashSet<TblStaffBioData>();
        }

        public int CompanyId { get; set; }
        public int? ProjectId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string EmailAddress { get; set; }
        public string WebsiteUrl { get; set; }
        public byte[] CompanyLogo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CompanyCode { get; set; }
        public string Description { get; set; }

        public virtual TblProjects Project { get; set; }
        public virtual ICollection<TblClients> TblClients { get; set; }
        public virtual ICollection<TblCompanySubContractors> TblCompanySubContractors { get; set; }
        public virtual ICollection<TblDepartments> TblDepartments { get; set; }
        public virtual ICollection<TblEndUserRequisitionServices> TblEndUserRequisitionServices { get; set; }
        public virtual ICollection<TblInvoice> TblInvoice { get; set; }
        public virtual ICollection<TblJobCompletionCertificate> TblJobCompletionCertificate { get; set; }
        public virtual ICollection<TblMtoforms> TblMtoforms { get; set; }
        public virtual ICollection<TblMtoformsTemp> TblMtoformsTemp { get; set; }
        public virtual ICollection<TblPurchaseOrder> TblPurchaseOrder { get; set; }
        public virtual ICollection<TblSrconstructionTechnicalQueries> TblSrconstructionTechnicalQueries { get; set; }
        public virtual ICollection<TblSrconstructionTechnicalQueriesTemp> TblSrconstructionTechnicalQueriesTemp { get; set; }
        public virtual ICollection<TblSrdailyReportHse> TblSrdailyReportHse { get; set; }
        public virtual ICollection<TblSrdailyReportHsetemp> TblSrdailyReportHsetemp { get; set; }
        public virtual ICollection<TblSrdailyReportOtherSiteReports> TblSrdailyReportOtherSiteReports { get; set; }
        public virtual ICollection<TblSrdailyReportOtherSiteReportsTemp> TblSrdailyReportOtherSiteReportsTemp { get; set; }
        public virtual ICollection<TblSrdailyReportProgressMeasurementMaster> TblSrdailyReportProgressMeasurementMaster { get; set; }
        public virtual ICollection<TblSrdailyReportProgressMeasurementMasterTemp> TblSrdailyReportProgressMeasurementMasterTemp { get; set; }
        public virtual ICollection<TblSrdailyReportingConstructionActivities> TblSrdailyReportingConstructionActivities { get; set; }
        public virtual ICollection<TblSrdailyReportingConstructionActivitiesTemp> TblSrdailyReportingConstructionActivitiesTemp { get; set; }
        public virtual ICollection<TblSrdailyReportingGeneralSummary> TblSrdailyReportingGeneralSummary { get; set; }
        public virtual ICollection<TblSrdailyReportingGeneralSummaryTemp> TblSrdailyReportingGeneralSummaryTemp { get; set; }
        public virtual ICollection<TblSrdailyReportingProgressPictures> TblSrdailyReportingProgressPictures { get; set; }
        public virtual ICollection<TblSrdailyReportingProgressPicturesTemp> TblSrdailyReportingProgressPicturesTemp { get; set; }
        public virtual ICollection<TblStaffBioData> TblStaffBioData { get; set; }
    }
}
