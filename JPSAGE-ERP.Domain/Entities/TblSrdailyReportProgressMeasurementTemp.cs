using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportProgressMeasurementTemp
    {
        public TblSrdailyReportProgressMeasurementTemp()
        {
            TblSrdailyReportingDelaysTemp = new HashSet<TblSrdailyReportingDelaysTemp>();
            TblSrdailyReportingIssuesTemp = new HashSet<TblSrdailyReportingIssuesTemp>();
        }

        public int ProMeId { get; set; }
        public string ProgressAt { get; set; }
        public decimal? ConstructionActual { get; set; }
        public decimal? Planned { get; set; }
        public string Activity { get; set; }
        public decimal CumProgressActual { get; set; }
        public decimal CumPlannedProgress { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string DocumentNumber { get; set; }
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }

        public virtual TblCompanyInfo Company { get; set; }
        public virtual TblProjects Project { get; set; }
        public virtual ICollection<TblSrdailyReportingDelaysTemp> TblSrdailyReportingDelaysTemp { get; set; }
        public virtual ICollection<TblSrdailyReportingIssuesTemp> TblSrdailyReportingIssuesTemp { get; set; }
    }
}
