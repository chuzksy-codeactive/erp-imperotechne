using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportProgressMeasurementDetails
    {
        public int ProMeId { get; set; }
        public string Activity { get; set; }
        public decimal CumProgressActual { get; set; }
        public decimal CumPlannedProgress { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? ProMeMasterId { get; set; }

        public virtual TblSrdailyReportProgressMeasurementMaster ProMeMaster { get; set; }
    }
}
