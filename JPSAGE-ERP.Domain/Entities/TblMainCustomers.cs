using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMainCustomers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int? CountryId { get; set; }
        public int SupplierId { get; set; }
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }
        public int? ProvisionType { get; set; }
        public int? ValueYear { get; set; }
        public decimal? Value { get; set; }

        public virtual TblCountry Country { get; set; }
        public virtual TblProducts Product { get; set; }
        public virtual TblServices Service { get; set; }
        public virtual TblSupplierIdentification Supplier { get; set; }
    }
}
