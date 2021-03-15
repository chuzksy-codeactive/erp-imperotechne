using System;
using System.Collections.Generic;

namespace Cache.API.Entities
{
    public class MaterialTakeOff
    {
        public MaterialTakeOff()
        {
            MtoElectricalDetails = new HashSet<MtoElectricalDetails>();
            MtoPipingDetails = new HashSet<MtoPipingDetails>();
            MtoInstrumentDetails = new HashSet<MtoInstrumentDetails>();
            MtoCivilDetails = new HashSet<MtoCivilDetails>();
        }
        public string UserEmail { get; set; }
        public int ProjectId { get; set; }
        public int? CompanyId { get; set; }
        public int DisciplineId { get; set; }
        public int SubDisciplineId { get; set; }
        public int? ClientId { get; set; }
        public string Title { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public int? ValidityStatus { get; set; }
        public string CreatedBy { get; set; }
        public ICollection<MtoElectricalDetails> MtoElectricalDetails { get; set; }
        public ICollection<MtoPipingDetails> MtoPipingDetails { get; set; }
        public ICollection<MtoInstrumentDetails> MtoInstrumentDetails { get; set; }
        public ICollection<MtoCivilDetails> MtoCivilDetails { get; set; }
    }
}
