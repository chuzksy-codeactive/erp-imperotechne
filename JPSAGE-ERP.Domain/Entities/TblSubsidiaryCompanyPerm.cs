using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSubsidiaryCompanyPerm
    {
        public int SubsidiaryId { get; set; }
        public int SupplierId { get; set; }
        public string SubsidiaryCompanyName { get; set; }

        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
