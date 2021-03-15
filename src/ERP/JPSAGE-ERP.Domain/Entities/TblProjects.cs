using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblProjects
    {
        public TblProjects()
        {
            TblCompanyInfo = new HashSet<TblCompanyInfo>();
            TblEndUserRequisitionProducts = new HashSet<TblEndUserRequisitionProducts>();
            TblEndUserRequisitionServices = new HashSet<TblEndUserRequisitionServices>();
            TblJustificationofAward = new HashSet<TblJustificationofAward>();
            TblMtoforms = new HashSet<TblMtoforms>();
            TblMtoformsTemp = new HashSet<TblMtoformsTemp>();
            TblPurchaseOrder = new HashSet<TblPurchaseOrder>();
            TblQuotationMaster = new HashSet<TblQuotationMaster>();
            TblSingleTenderJustification = new HashSet<TblSingleTenderJustification>();
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
            TblSrnonConformanceReports = new HashSet<TblSrnonConformanceReports>();
            TblSrnonConformanceReportsTemp = new HashSet<TblSrnonConformanceReportsTemp>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<TblCompanyInfo> TblCompanyInfo { get; set; }
        public virtual ICollection<TblEndUserRequisitionProducts> TblEndUserRequisitionProducts { get; set; }
        public virtual ICollection<TblEndUserRequisitionServices> TblEndUserRequisitionServices { get; set; }
        public virtual ICollection<TblJustificationofAward> TblJustificationofAward { get; set; }
        public virtual ICollection<TblMtoforms> TblMtoforms { get; set; }
        public virtual ICollection<TblMtoformsTemp> TblMtoformsTemp { get; set; }
        public virtual ICollection<TblPurchaseOrder> TblPurchaseOrder { get; set; }
        public virtual ICollection<TblQuotationMaster> TblQuotationMaster { get; set; }
        public virtual ICollection<TblSingleTenderJustification> TblSingleTenderJustification { get; set; }
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
        public virtual ICollection<TblSrnonConformanceReports> TblSrnonConformanceReports { get; set; }
        public virtual ICollection<TblSrnonConformanceReportsTemp> TblSrnonConformanceReportsTemp { get; set; }
    }
}
