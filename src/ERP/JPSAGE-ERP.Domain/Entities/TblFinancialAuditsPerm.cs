using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblFinancialAuditsPerm
    {
        public int FinAudId { get; set; }
        public int SupplierId { get; set; }
        public string AnnualReport { get; set; }
        public string TaxIdentificationNo { get; set; }
        public string AuditorName { get; set; }
        public string AuditorAddress { get; set; }
        public string ContactNumber { get; set; }
        public bool? IsListed { get; set; }
        public string StockMarketInfo { get; set; }

        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
