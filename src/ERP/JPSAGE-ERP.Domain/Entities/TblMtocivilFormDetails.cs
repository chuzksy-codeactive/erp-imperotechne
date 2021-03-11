using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMtocivilFormDetails
    {
        public int CivFormDetId { get; set; }
        public int CivFormId { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public int? UnitId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Total { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual TblMtocivilForm CivForm { get; set; }
        public virtual TblUnits Unit { get; set; }
    }
}
