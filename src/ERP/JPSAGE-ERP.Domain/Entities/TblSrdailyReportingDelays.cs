using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportingDelays
    {
        public int DelayId { get; set; }
        public string DescriptionofDelay { get; set; }
        public string Cause { get; set; }
        public int? Responsible { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? ProMeMasterId { get; set; }
        public DateTime? TimeTakenFrom { get; set; }
        public DateTime? TimeTakenTo { get; set; }

        public virtual TblSrdailyReportProgressMeasurementMaster ProMeMaster { get; set; }
        public virtual TblStaffBioData ResponsibleNavigation { get; set; }
    }
}
