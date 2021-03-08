using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblFinancialStatementsPerm
    {
        public int FinStatId { get; set; }
        public int SupplierId { get; set; }
        public int? FinancialStatementYear { get; set; }
        public string FinancialStatement { get; set; }

        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
