using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportingProgressPictures
    {
        public TblSrdailyReportingProgressPictures()
        {
            TblSrdrprogressPicturesAttachments = new HashSet<TblSrdrprogressPicturesAttachments>();
        }

        public int Ppid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string DocumentNumber { get; set; }
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }

        public virtual TblCompanyInfo Company { get; set; }
        public virtual TblProjects Project { get; set; }
        public virtual ICollection<TblSrdrprogressPicturesAttachments> TblSrdrprogressPicturesAttachments { get; set; }
    }
}
