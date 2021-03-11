using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportHseattachmentsTemp
    {
        public TblSrdailyReportHseattachmentsTemp()
        {
            TblSrdailyReportHsetemp = new HashSet<TblSrdailyReportHsetemp>();
        }

        public int DrhseattId { get; set; }
        public string PermitToWork { get; set; }
        public string SecurityReport { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<TblSrdailyReportHsetemp> TblSrdailyReportHsetemp { get; set; }
    }
}
