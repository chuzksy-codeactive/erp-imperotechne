using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportHsetemp
    {
        public int Drhseid { get; set; }
        public string Title { get; set; }
        public string DetailsStatistics { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string DocumentNumber { get; set; }
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }
        public int? DrhseattId { get; set; }

        public virtual TblCompanyInfo Company { get; set; }
        public virtual TblSrdailyReportHseattachmentsTemp Drhseatt { get; set; }
        public virtual TblProjects Project { get; set; }
    }
}
