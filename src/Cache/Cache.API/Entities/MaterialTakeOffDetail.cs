namespace Cache.API.Entities
{
    public class MaterialTakeOffDetail
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
