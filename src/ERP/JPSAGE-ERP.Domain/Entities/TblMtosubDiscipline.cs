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
            TblMtoforms = new HashSet<TblMtoforms>();
            TblMtoformsTemp = new HashSet<TblMtoformsTemp>();
        }

        public int SubDisciplineId { get; set; }
        public int DisciplineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual TblMtodiscipline Discipline { get; set; }
        public virtual ICollection<TblEndUserRequisitionProductsMto> TblEndUserRequisitionProductsMto { get; set; }
        public virtual ICollection<TblEndUserRequisitionServicesMto> TblEndUserRequisitionServicesMto { get; set; }
        public virtual ICollection<TblMtoforms> TblMtoforms { get; set; }
        public virtual ICollection<TblMtoformsTemp> TblMtoformsTemp { get; set; }
    }
}
