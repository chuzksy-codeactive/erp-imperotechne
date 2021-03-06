using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrconstructionTechnicalQueryRepliesTemp
    {
        public int ReplyId { get; set; }
        public int Ctqid { get; set; }
        public string InitiatorReply { get; set; }
        public DateTime? InitiatorReplyDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? QueryCloseDate { get; set; }
        public string AttentionReply { get; set; }
        public DateTime? AttentionReplyDate { get; set; }
        public int? InitiatorAcceptance { get; set; }

        public virtual TblSrconstructionTechnicalQueriesTemp Ctq { get; set; }
    }
}
