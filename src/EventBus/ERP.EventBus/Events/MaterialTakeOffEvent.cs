using System;
using System.Collections.Generic;

namespace ERP.EventBus.Events
{
    public class MaterialTakeOffEvent
    {
        public MaterialTakeOffEvent()
        {
            MtoCivilDetailsEvents = new HashSet<MtoCivilDetailsEvent>();
            MtoInstrumentDetailsEvents = new HashSet<MtoInstrumentDetailsEvent>();
            MtoPipingDetailsEvents = new HashSet<MtoPipingDetailsEvent>();
            MtoElectricalDetailsEvents = new HashSet<MtoElectricalDetailsEvent>();
        }

        public Guid RequestId { get; set; }
        public string UserEmail { get; set; }
        public int ProjectId { get; set; }
        public int DisciplineId { get; set; }
        public int SubDisciplineId { get; set; }
        public string DocumentNumber { get; set; }
        public string Title { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public int ValidityStatus { get; set; }
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public string CreatedBy { get; set; }
        public ICollection<MtoCivilDetailsEvent> MtoCivilDetailsEvents { get; set; }
        public ICollection<MtoElectricalDetailsEvent> MtoElectricalDetailsEvents { get; set; }
        public ICollection<MtoPipingDetailsEvent> MtoPipingDetailsEvents { get; set; }
        public ICollection<MtoInstrumentDetailsEvent> MtoInstrumentDetailsEvents { get; set; }
    }

    public class MtoElectricalDetailsEvent
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

    public class MtoPipingDetailsEvent
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

    public class MtoInstrumentDetailsEvent
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

    public class MtoCivilDetailsEvent
    {
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public int? UnitId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Total { get; set; }
    }
}
