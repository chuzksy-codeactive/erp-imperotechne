using System;
using System.Collections.Generic;

namespace Cache.API.Model
{
    public class MaterialTakeOffDto
    {
        public MaterialTakeOffDto()
        {
            MaterialTakeOffDetails = new HashSet<MaterialTakeOffDetailDto>();
        }
        public string UserEmail { get; set; }
        public int ProjectId { get; set; }
        public int MtodisciplineId { get; set; }
        public int MtosubDisciplineId { get; set; }
        public string DocumentNumber { get; set; }
        public string Title { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public int ValidityStatus { get; set; }
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public string CreatedBy { get; set; }
        public ICollection<MaterialTakeOffDetailDto> MaterialTakeOffDetails { get; set; }
    }
}
