using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSrncrattachments
    {
        public int NcrattId { get; set; }
        public int Ncrid { get; set; }
        public string DrawingFile { get; set; }
        public string ReferenceNumber { get; set; }
        public string Ncrimages { get; set; }
        public string DescriptionDocuments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual TblSrnonConformanceReports Ncr { get; set; }
    }
}
