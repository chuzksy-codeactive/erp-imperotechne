using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblTypicalSubcontractedScopePerm
    {
        public int SubConScopeId { get; set; }
        public string SubConName { get; set; }
        public string SubConAddress { get; set; }
        public int? CountryId { get; set; }
        public int? SupplierId { get; set; }
        public bool? IsLocal { get; set; }
        public string Product { get; set; }

        public virtual TblCountry Country { get; set; }
        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
