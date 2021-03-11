using System;
using System.Collections.Generic;

namespace Cache.API.Entities
{
    public class MaterialTakeOff
    {
        public MaterialTakeOff()
        {
            MaterialTakeOffDetails = new HashSet<MaterialTakeOffDetail>();
        }
        public string UserEmail { get; set; }
        public int ProjectId { get; set; }
        public int MtodisciplineId { get; set; }
        public int MtosubDisciplineId { get; set; }
        public string DocumentNumber { get; set; }
        public string Title { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public int? ValidityStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? ClientId { get; set; }
        public string CreatedBy { get; set; }
        public ICollection<MaterialTakeOffDetail> MaterialTakeOffDetails { get; set; }
    }
}
