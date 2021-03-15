using System;

namespace Cache.API.Model
{
    public class MtoElectricalDetailsDto
    {
        public Guid ItemId { get; set; } = Guid.NewGuid();
        public string ItemDescription { get; set; }
        public int UnitId { get; set; }
        public int QuantityRequired { get; set; }
        public int QuantitytoBuy { get; set; }
        public decimal Voltage { get; set; }
        public decimal Weight { get; set; }
        public decimal GlandSize { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Remarks { get; set; }
    }

    public class MtoPipingDetailsDto
    {
        public Guid ItemId { get; set; } = Guid.NewGuid();
        public string Item { get; set; }
        public int Size { get; set; }
        public string Schedule { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public int ActualQuantityReq { get; set; }
        public decimal Spare { get; set; }
        public int TotalReq { get; set; }
        public int UnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class MtoInstrumentDetailsDto
    {
        public Guid ItemId { get; set; } = Guid.NewGuid();
        public string ItemDescription { get; set; }
        public int MaterialId { get; set; }
        public int Quantity { get; set; }
        public string MarkedUpQuantity { get; set; }
        public int UnitToOrder { get; set; }
        public int UnitId { get; set; }
        public int ManufacturerId { get; set; }
        public string ModelNumber { get; set; }
        public string Comments { get; set; }
        public int QuantityRequired { get; set; }
        public int QuantitytoBuy { get; set; }
        public string Remarks { get; set; }
    }

    public class MtoCivilDetailsDto
    {
        public Guid ItemId { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int UnitId { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }
}
