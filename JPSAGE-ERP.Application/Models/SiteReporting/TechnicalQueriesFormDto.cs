using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Application.Models.SiteReporting
{
    public class TechnicalQueriesFormDto
    {
        public int ProjectId { get; set; }
        public string CtqTitle { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public DateTime QueryDate { get; set; }
        public string CtqDescription { get; set; }
        public int AttendeeId { get; set; }
        public DateTime ReplyRequiredBy { get; set; }
        public int Priority { get; set; }
        public string DrawingFile { get; set; }
    }

    public class InitiatorReplyFormDto
    {
        public string InitiatorReply { get; set; }
        public int InitiatorAcceptance { get; set; }
        public DateTime InitiatorReplyDate { get; set; }
    }

    public class AttentionReplyFormDto
    {
        public string AttentionReply { get; set; }
        public DateTime AttentionDate { get; set; }
    }

    public class ConstructionTechnicalQueryDto
    {
        public int CtqId { get; set; }
        public string ProjectName { get; set; }
        public string CtqTitle { get; set; }
        public string AttendeeName { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsInitiator { get; set; }
    }

    public class ConstructionTechnicalQueryRepliesDto : ConstructionTechnicalQueryDto
    {
        public ConstructionTechnicalQueryRepliesDto()
        {
            CtqReplies = new HashSet<CtqRepliesDto>();
        }

        public ICollection<CtqRepliesDto> CtqReplies { get; set; }
        public string InitiatorName { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
    }

    public class CtqRepliesDto
    {
        public int ReplyId { get; set; }
        public string InitiatorReply { get; set; }
        public DateTime? InitiatorReplyDate { get; set; }
        public string AttentionReply { get; set; }
        public DateTime? AttentionReplyDate { get; set; }
        public string  InitiatorAcceptance { get; set; }
    }
}
