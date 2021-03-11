using System;
using System.Collections.Generic;

namespace ERP.EventBus.Events
{
    public class MaterialTakeOffEvent
    {
        public MaterialTakeOffEvent()
        {
            MaterialTakeOffDetails = new HashSet<MaterialTakeOffDetailEvent>();
        }

        public Guid RequestId { get; set; }
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
        public ICollection<MaterialTakeOffDetailEvent> MaterialTakeOffDetails { get; set; }
    }

    public class MaterialTakeOffDetailEvent
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int UnitId { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }
}
