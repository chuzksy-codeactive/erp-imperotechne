using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMtoelectricalFormTemp
    {
        public TblMtoelectricalFormTemp()
        {
            TblMtoelectricalFormDetailsTemp = new HashSet<TblMtoelectricalFormDetailsTemp>();
        }

        public int EleFormId { get; set; }
        public int ProjectId { get; set; }
        public int MtodisciplineId { get; set; }
        public int MtosubDisciplineId { get; set; }
        public string DocumentNumber { get; set; }
        public string Title { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public int? ValidityStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? ClientId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual TblClients Client { get; set; }
        public virtual TblCompanyInfo Company { get; set; }
        public virtual TblMtodiscipline Mtodiscipline { get; set; }
        public virtual TblMtosubDiscipline MtosubDiscipline { get; set; }
        public virtual TblProjects Project { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetailsTemp> TblMtoelectricalFormDetailsTemp { get; set; }
    }
}
