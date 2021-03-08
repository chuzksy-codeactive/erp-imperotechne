using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblStaffStrengthCompPerm
    {
        public TblStaffStrengthCompPerm()
        {
            TblNumberOfEmployeesPerm = new HashSet<TblNumberOfEmployeesPerm>();
        }

        public int StaffStrCompId { get; set; }
        public int SupplierId { get; set; }
        public string StaffPolicy { get; set; }
        public string Audit3rdParty { get; set; }

        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
        public virtual ICollection<TblNumberOfEmployeesPerm> TblNumberOfEmployeesPerm { get; set; }
    }
}
