using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSubContractedServicesPerm
    {
        public int SubServId { get; set; }
        public decimal? PercentageOutsourced { get; set; }
        public int? SupplierId { get; set; }
        public int? ServiceId { get; set; }

        public virtual TblServices Service { get; set; }
        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
