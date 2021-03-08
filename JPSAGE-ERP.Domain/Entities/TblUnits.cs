using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblUnits
    {
        public TblUnits()
        {
            TblEndUserRequisitionProductsDetails = new HashSet<TblEndUserRequisitionProductsDetails>();
            TblMtocivilFormDetails = new HashSet<TblMtocivilFormDetails>();
            TblMtocivilFormDetailsTemp = new HashSet<TblMtocivilFormDetailsTemp>();
            TblMtoelectricalFormDetails = new HashSet<TblMtoelectricalFormDetails>();
            TblMtoelectricalFormDetailsTemp = new HashSet<TblMtoelectricalFormDetailsTemp>();
            TblMtoinstrumentFormDetails = new HashSet<TblMtoinstrumentFormDetails>();
            TblMtoinstrumentFormDetailsTemp = new HashSet<TblMtoinstrumentFormDetailsTemp>();
        }

        public int UnitId { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<TblEndUserRequisitionProductsDetails> TblEndUserRequisitionProductsDetails { get; set; }
        public virtual ICollection<TblMtocivilFormDetails> TblMtocivilFormDetails { get; set; }
        public virtual ICollection<TblMtocivilFormDetailsTemp> TblMtocivilFormDetailsTemp { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetails> TblMtoelectricalFormDetails { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetailsTemp> TblMtoelectricalFormDetailsTemp { get; set; }
        public virtual ICollection<TblMtoinstrumentFormDetails> TblMtoinstrumentFormDetails { get; set; }
        public virtual ICollection<TblMtoinstrumentFormDetailsTemp> TblMtoinstrumentFormDetailsTemp { get; set; }
    }
}
