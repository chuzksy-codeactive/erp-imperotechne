using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportOtherSiteReports
    {
        public int OsrepId { get; set; }
        public string Qaqcreport { get; set; }
        public string LogisticsReport { get; set; }
        public string SitePersonnelLogReport { get; set; }
        public string MaterialReport { get; set; }
        public string Mocreport { get; set; }
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
