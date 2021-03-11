using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdrprogressPicturesAttachments
    {
        public int ProPicAttId { get; set; }
        public string ProgressPictures { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? Ppid { get; set; }
        public string Description { get; set; }

        public virtual TblSrdailyReportingProgressPictures Pp { get; set; }
    }
}
