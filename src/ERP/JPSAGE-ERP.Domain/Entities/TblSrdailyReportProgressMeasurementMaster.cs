using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportProgressMeasurementMaster
    {
        public TblSrdailyReportProgressMeasurementMaster()
        {
            TblSrdailyReportProgressMeasurementDetails = new HashSet<TblSrdailyReportProgressMeasurementDetails>();
            TblSrdailyReportingDelays = new HashSet<TblSrdailyReportingDelays>();
            TblSrdailyReportingIssues = new HashSet<TblSrdailyReportingIssues>();
        }

        public int ProMeMasterId { get; set; }
        public string ProgressAt { get; set; }
        public decimal? ConstructionActual { get; set; }
        public decimal? Planned { get; set; }
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string DocumentNumber { get; set; }

        public virtual TblCompanyInfo Company { get; set; }
        public virtual TblProjects Project { get; set; }
        public virtual ICollection<TblSrdailyReportProgressMeasurementDetails> TblSrdailyReportProgressMeasurementDetails { get; set; }
        public virtual ICollection<TblSrdailyReportingDelays> TblSrdailyReportingDelays { get; set; }
        public virtual ICollection<TblSrdailyReportingIssues> TblSrdailyReportingIssues { get; set; }
    }
}
