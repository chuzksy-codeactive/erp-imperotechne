using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrdailyReportingGenSumAttachmentsTemp
    {
        public TblSrdailyReportingGenSumAttachmentsTemp()
        {
            TblSrdailyReportingGeneralSummaryTemp = new HashSet<TblSrdailyReportingGeneralSummaryTemp>();
        }

        public int DrgsattId { get; set; }
        public string OtherAttachment { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<TblSrdailyReportingGeneralSummaryTemp> TblSrdailyReportingGeneralSummaryTemp { get; set; }
    }
}
