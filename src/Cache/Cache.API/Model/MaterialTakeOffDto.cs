using System;
using System.Collections.Generic;

namespace Cache.API.Model
{
    public class MaterialTakeOffDto
    {
        public MaterialTakeOffDto()
        {
            MtoCivilDetails = new HashSet<MtoCivilDetailsDto>();
            MtoElectricalDetails = new HashSet<MtoElectricalDetailsDto>();
            MtoPipingDetails = new HashSet<MtoPipingDetailsDto>();
            MtoInstrumentDetails = new HashSet<MtoInstrumentDetailsDto>();
        }
        public string UserEmail { get; set; }
        public int ProjectId { get; set; }
        public int DisciplineId { get; set; }
        public int SubDisciplineId { get; set; }
        public string Title { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public int ValidityStatus { get; set; }
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public ICollection<MtoCivilDetailsDto> MtoCivilDetails { get; set; }
        public ICollection<MtoElectricalDetailsDto> MtoElectricalDetails { get; set; }
        public ICollection<MtoPipingDetailsDto> MtoPipingDetails { get; set; }
        public ICollection<MtoInstrumentDetailsDto> MtoInstrumentDetails { get; set; }
    }

    public class MtoDisciplineDetailsDto
    {
        public MtoDisciplineDetailsDto()
        {
            MtoCivilDetails = new HashSet<MtoCivilDetailsDto>();
            MtoElectricalDetails = new HashSet<MtoElectricalDetailsDto>();
            MtoPipingDetails = new HashSet<MtoPipingDetailsDto>();
            MtoInstrumentDetails = new HashSet<MtoInstrumentDetailsDto>();
        }

        public ICollection<MtoCivilDetailsDto> MtoCivilDetails { get; set; }
        public ICollection<MtoElectricalDetailsDto> MtoElectricalDetails { get; set; }
        public ICollection<MtoPipingDetailsDto> MtoPipingDetails { get; set; }
        public ICollection<MtoInstrumentDetailsDto> MtoInstrumentDetails { get; set; }
    }

    public class MtoDisciplineDetailDto
    {
        public MtoCivilDetailsDto MtoCivilDetail { get; set; }
        public MtoElectricalDetailsDto MtoElectricalDetail { get; set; }
        public MtoPipingDetailsDto MtoPipingDetail { get; set; }
        public MtoInstrumentDetailsDto MtoInstrumentDetail { get; set; }
    }
}
