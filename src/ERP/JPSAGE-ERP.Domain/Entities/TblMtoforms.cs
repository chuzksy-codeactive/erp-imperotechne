using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMtoforms
    {
        public TblMtoforms()
        {
            TblMtocivilFormDetails = new HashSet<TblMtocivilFormDetails>();
            TblMtocivilFormDetailsTemp = new HashSet<TblMtocivilFormDetailsTemp>();
            TblMtoelectricalFormDetails = new HashSet<TblMtoelectricalFormDetails>();
            TblMtoelectricalFormDetailsTemp = new HashSet<TblMtoelectricalFormDetailsTemp>();
            TblMtoinstrumentFormDetails = new HashSet<TblMtoinstrumentFormDetails>();
            TblMtoinstrumentFormDetailsTemp = new HashSet<TblMtoinstrumentFormDetailsTemp>();
        }

        public int MtoformId { get; set; }
        public int ProjectId { get; set; }
        public int? CompanyId { get; set; }
        public int DisciplineId { get; set; }
        public int SubDisciplineId { get; set; }
        public int? ClientId { get; set; }
        public string DocumentNumber { get; set; }
        public string Title { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public int? ValidityStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual TblClients Client { get; set; }
        public virtual TblCompanyInfo Company { get; set; }
        public virtual TblMtodiscipline Discipline { get; set; }
        public virtual TblProjects Project { get; set; }
        public virtual TblMtosubDiscipline SubDiscipline { get; set; }
        public virtual ICollection<TblMtocivilFormDetails> TblMtocivilFormDetails { get; set; }
        public virtual ICollection<TblMtocivilFormDetailsTemp> TblMtocivilFormDetailsTemp { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetails> TblMtoelectricalFormDetails { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetailsTemp> TblMtoelectricalFormDetailsTemp { get; set; }
        public virtual ICollection<TblMtoinstrumentFormDetails> TblMtoinstrumentFormDetails { get; set; }
        public virtual ICollection<TblMtoinstrumentFormDetailsTemp> TblMtoinstrumentFormDetailsTemp { get; set; }
    }
}
