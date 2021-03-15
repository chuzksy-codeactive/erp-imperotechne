using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Application.Models
{
    public class MtoDto
    {
        public MtoDto()
        {
            MtoElectricalDetails = new HashSet<MtoElectricalDetailsDto>();
            MtoPipingDetails = new HashSet<MtoPipingDetailsDto>();
            MtoInstrumentDetails = new HashSet<MtoInstrumentDetailsDto>();
            MtoCivilDetails = new HashSet<MtoCivilDetailsDto>();
        }

        public int ProjectId { get; set; }
        public int MtodisciplineId { get; set; }
        public int DisciplineId { get; set; }
        public int SubDisciplineId { get; set; }
        public string Title { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public int? ValidityStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? ClientId { get; set; }
        public string CreatedBy { get; set; }
        public ICollection<MtoElectricalDetailsDto> MtoElectricalDetails { get; set; }
        public ICollection<MtoPipingDetailsDto> MtoPipingDetails { get; set; }
        public ICollection<MtoInstrumentDetailsDto> MtoInstrumentDetails { get; set; }
        public ICollection<MtoCivilDetailsDto> MtoCivilDetails { get; set; }
    }

    public class MtoElectricalDetailsDto
    {
        public string ItemDescription { get; set; }
        public int? UnitId { get; set; }
        public int? QuantityRequired { get; set; }
        public int? QuantitytoBuy { get; set; }
        public decimal? Voltage { get; set; }
        public decimal? Weight { get; set; }
        public decimal? GlandSize { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string Remarks { get; set; }
    }

    public class MtoPipingDetailsDto
    {
        public string Item { get; set; }
        public int? Size { get; set; }
        public string Schedule { get; set; }
        public int? Rating { get; set; }
        public string Description { get; set; }
        public int? ActualQuantityReq { get; set; }
        public decimal? Spare { get; set; }
        public int? TotalReq { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
    }

    public class MtoInstrumentDetailsDto
    {
        public string ItemDescription { get; set; }
        public int? MaterialId { get; set; }
        public int? Quantity { get; set; }
        public string MarkedUpQuantity { get; set; }
        public int? UnitToOrder { get; set; }
        public int? UnitId { get; set; }
        public int? ManufacturerId { get; set; }
        public string ModelNumber { get; set; }
        public string Comments { get; set; }
        public int? QuantityRequired { get; set; }
        public int? QuantitytoBuy { get; set; }
        public string Remarks { get; set; }
    }

    public class MtoCivilDetailsDto
    {
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public int? UnitId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Total { get; set; }
    }

    public class MtoDisciplineDto
    {
        public int DisciplineId { get; set; }
        public string Name { get; set; }
    }

    public class MtoSubdisciplineDto
    {
        public int SubDisciplineId { get; set; }
        public string Name { get; set; }
    }

    public class MtoViewModelDto
    {
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }
        public string FormType { get; set; }
        public int NoOfItems { get; set; }
        public string Status { get; set; }
    }
}
