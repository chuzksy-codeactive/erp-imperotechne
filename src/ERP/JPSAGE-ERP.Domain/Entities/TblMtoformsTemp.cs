using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMtoformsTemp
    {
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
    }
}
