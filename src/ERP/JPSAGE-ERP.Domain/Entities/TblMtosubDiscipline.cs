using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMtosubDiscipline
    {
        public TblMtosubDiscipline()
        {
            TblEndUserRequisitionProductsMto = new HashSet<TblEndUserRequisitionProductsMto>();
            TblEndUserRequisitionServicesMto = new HashSet<TblEndUserRequisitionServicesMto>();
            TblMtocivilForm = new HashSet<TblMtocivilForm>();
            TblMtocivilFormTemp = new HashSet<TblMtocivilFormTemp>();
            TblMtoelectricalForm = new HashSet<TblMtoelectricalForm>();
            TblMtoelectricalFormTemp = new HashSet<TblMtoelectricalFormTemp>();
            TblMtoinstrumentForm = new HashSet<TblMtoinstrumentForm>();
            TblMtoinstrumentFormTemp = new HashSet<TblMtoinstrumentFormTemp>();
            TblMtopipingForm = new HashSet<TblMtopipingForm>();
            TblMtopipingFormTemp = new HashSet<TblMtopipingFormTemp>();
        }

        public int SubDisciplineId { get; set; }
        public int DisciplineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual TblMtodiscipline Discipline { get; set; }
        public virtual ICollection<TblEndUserRequisitionProductsMto> TblEndUserRequisitionProductsMto { get; set; }
        public virtual ICollection<TblEndUserRequisitionServicesMto> TblEndUserRequisitionServicesMto { get; set; }
        public virtual ICollection<TblMtocivilForm> TblMtocivilForm { get; set; }
        public virtual ICollection<TblMtocivilFormTemp> TblMtocivilFormTemp { get; set; }
        public virtual ICollection<TblMtoelectricalForm> TblMtoelectricalForm { get; set; }
        public virtual ICollection<TblMtoelectricalFormTemp> TblMtoelectricalFormTemp { get; set; }
        public virtual ICollection<TblMtoinstrumentForm> TblMtoinstrumentForm { get; set; }
        public virtual ICollection<TblMtoinstrumentFormTemp> TblMtoinstrumentFormTemp { get; set; }
        public virtual ICollection<TblMtopipingForm> TblMtopipingForm { get; set; }
        public virtual ICollection<TblMtopipingFormTemp> TblMtopipingFormTemp { get; set; }
    }
}
