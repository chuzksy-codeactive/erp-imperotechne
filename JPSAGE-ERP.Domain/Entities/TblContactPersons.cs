using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblContactPersons
    {
        public int ContactPersonId { get; set; }
        public string ContactPersonName { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int? FormId { get; set; }
        public int? SupplierId { get; set; }
        public int? VenPosId { get; set; }

        public virtual TblFormIdentification Form { get; set; }
        public virtual TblSupplierIdentification Supplier { get; set; }
        public virtual TblVendorPositions VenPos { get; set; }
    }
}
