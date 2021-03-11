using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblEndUserRequisitionServiceAttachments
    {
        public int Eursaid { get; set; }
        public int Eursid { get; set; }
        public string ReferenceDrawingTitle { get; set; }
        public string ReferenceDrawingNo { get; set; }
        public string ReferenceDrawingFiles { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string WorkSchedule { get; set; }
        public string CommercialTemplate { get; set; }
        public string TermsConditions { get; set; }

        public virtual TblEndUserRequisitionServices Eurs { get; set; }
    }
}
