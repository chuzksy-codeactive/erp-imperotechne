using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMaterials
    {
        public TblMaterials()
        {
            TblMtoinstrumentFormDetails = new HashSet<TblMtoinstrumentFormDetails>();
            TblMtoinstrumentFormDetailsTemp = new HashSet<TblMtoinstrumentFormDetailsTemp>();
        }

        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<TblMtoinstrumentFormDetails> TblMtoinstrumentFormDetails { get; set; }
        public virtual ICollection<TblMtoinstrumentFormDetailsTemp> TblMtoinstrumentFormDetailsTemp { get; set; }
    }
}
