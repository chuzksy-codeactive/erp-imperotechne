using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Application.Models.SiteReporting
{
    public class NonConformanceReporFormtDto
    {
        public string Title { get; set; }
        public int ProjectId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string Description { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string Item { get; set; }
        public string SystemsSubSystems { get; set; }
        public int SupplierId { get; set; }
        public bool? ReqEngApproval { get; set; }
        public string DocumentReqViolated { get; set; }
        public NcrAttachmentDto NcrAttachments { get; set; }

    }

    public class NcrAttachmentDto
    {
        public string[] DrawingFile { get; set; } = new string[] {};
        public string[] NCRImages { get; set; } = new string[] {};
        public string[] DescriptionDocuments { get; set; } = new string[] { };
    }
}
