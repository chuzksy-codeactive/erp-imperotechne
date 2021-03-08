using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSpDirectServiceScope
    {
        public int SpDssId { get; set; }
        public int? ServiceId { get; set; }
        public string Description { get; set; }
        public int? SupplierId { get; set; }

        public virtual TblServices Service { get; set; }
        public virtual TblSupplierIdentification Supplier { get; set; }
    }
}
