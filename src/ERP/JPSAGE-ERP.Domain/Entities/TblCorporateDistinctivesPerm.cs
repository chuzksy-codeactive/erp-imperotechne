using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblCorporateDistinctivesPerm
    {
        public int CorpDisId { get; set; }
        public int SupplierId { get; set; }
        public string Details { get; set; }

        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
