using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportingConstructionActivities
    {
        public int DrconActId { get; set; }
        public string ConstructionActivities { get; set; }
        public string DailyProgress { get; set; }
        public string FollowingDayPlan { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string DocumentNumber { get; set; }
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }

        public virtual TblCompanyInfo Company { get; set; }
        public virtual TblProjects Project { get; set; }
    }
}
