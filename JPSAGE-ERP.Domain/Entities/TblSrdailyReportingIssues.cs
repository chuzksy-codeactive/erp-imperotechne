using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportingIssues
    {
        public int IssueId { get; set; }
        public string Challenges { get; set; }
        public string Recommendations { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? ProMeMasterId { get; set; }

        public virtual TblSrdailyReportProgressMeasurementMaster ProMeMaster { get; set; }
    }
}
