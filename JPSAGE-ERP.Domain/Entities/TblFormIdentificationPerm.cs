using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblFormIdentificationPerm
    {
        public TblFormIdentificationPerm()
        {
            TblContactPersonsPerm = new HashSet<TblContactPersonsPerm>();
            TblSupplierIdentificationPerm = new HashSet<TblSupplierIdentificationPerm>();
            TblThirdPartyReferencePerm = new HashSet<TblThirdPartyReferencePerm>();
        }

        public int FormId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? Date { get; set; }
        public int? VenPosId { get; set; }

        public virtual TblVendorPositions VenPos { get; set; }
        public virtual ICollection<TblContactPersonsPerm> TblContactPersonsPerm { get; set; }
        public virtual ICollection<TblSupplierIdentificationPerm> TblSupplierIdentificationPerm { get; set; }
        public virtual ICollection<TblThirdPartyReferencePerm> TblThirdPartyReferencePerm { get; set; }
    }
}
