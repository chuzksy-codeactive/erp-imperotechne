using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblVendorPositions
    {
        public TblVendorPositions()
        {
            TblContactPersons = new HashSet<TblContactPersons>();
            TblContactPersonsPerm = new HashSet<TblContactPersonsPerm>();
            TblFormIdentification = new HashSet<TblFormIdentification>();
            TblFormIdentificationPerm = new HashSet<TblFormIdentificationPerm>();
        }

        public int VenPosId { get; set; }
        public string VenPosCode { get; set; }
        public string VenPosTitle { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<TblContactPersons> TblContactPersons { get; set; }
        public virtual ICollection<TblContactPersonsPerm> TblContactPersonsPerm { get; set; }
        public virtual ICollection<TblFormIdentification> TblFormIdentification { get; set; }
        public virtual ICollection<TblFormIdentificationPerm> TblFormIdentificationPerm { get; set; }
    }
}
