using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportProgressMeasurementMasterTemp
    {
        public TblSrdailyReportProgressMeasurementMasterTemp()
        {
            TblSrdailyReportProgressMeasurementDetailsTemp = new HashSet<TblSrdailyReportProgressMeasurementDetailsTemp>();
            TblSrdailyReportingDelaysTemp = new HashSet<TblSrdailyReportingDelaysTemp>();
            TblSrdailyReportingIssuesTemp = new HashSet<TblSrdailyReportingIssuesTemp>();
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
        public virtual ICollection<TblSrdailyReportProgressMeasurementDetailsTemp> TblSrdailyReportProgressMeasurementDetailsTemp { get; set; }
        public virtual ICollection<TblSrdailyReportingDelaysTemp> TblSrdailyReportingDelaysTemp { get; set; }
        public virtual ICollection<TblSrdailyReportingIssuesTemp> TblSrdailyReportingIssuesTemp { get; set; }
    }
}
