using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblDocumentType
    {
        public TblDocumentType()
        {
            TblQuotationOtherInfoAttachments = new HashSet<TblQuotationOtherInfoAttachments>();
            TblTenderAttachements = new HashSet<TblTenderAttachements>();
        }

        public int DocTypeId { get; set; }
        public string DocTypeName { get; set; }
        public string DocTypeDescription { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<TblQuotationOtherInfoAttachments> TblQuotationOtherInfoAttachments { get; set; }
        public virtual ICollection<TblTenderAttachements> TblTenderAttachements { get; set; }
    }
}
