using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblManufacturers
    {
        public TblManufacturers()
        {
            TblMtoinstrumentFormDetails = new HashSet<TblMtoinstrumentFormDetails>();
            TblMtoinstrumentFormDetailsTemp = new HashSet<TblMtoinstrumentFormDetailsTemp>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Status { get; set; }
        public string StatusReason { get; set; }

        public virtual ICollection<TblMtoinstrumentFormDetails> TblMtoinstrumentFormDetails { get; set; }
        public virtual ICollection<TblMtoinstrumentFormDetailsTemp> TblMtoinstrumentFormDetailsTemp { get; set; }
    }
}
