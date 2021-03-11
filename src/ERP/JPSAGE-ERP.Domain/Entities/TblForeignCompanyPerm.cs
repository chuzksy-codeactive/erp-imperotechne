using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblForeignCompanyPerm
    {
        public int ForComId { get; set; }
        public string CompanyName { get; set; }
        public string ProductSupplied { get; set; }
        public int? Status { get; set; }
        public string Others { get; set; }
        public int SupplierId { get; set; }

        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
