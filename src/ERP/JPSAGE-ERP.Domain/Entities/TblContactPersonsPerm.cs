using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblContactPersonsPerm
    {
        public int ContactPersonId { get; set; }
        public string ContactPersonName { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int? FormId { get; set; }
        public int? SupplierId { get; set; }
        public int? VenPosId { get; set; }

        public virtual TblFormIdentificationPerm Form { get; set; }
        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
        public virtual TblVendorPositions VenPos { get; set; }
    }
}
