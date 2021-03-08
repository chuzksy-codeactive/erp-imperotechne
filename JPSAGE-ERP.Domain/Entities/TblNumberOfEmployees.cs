using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblNumberOfEmployees
    {
        public int NoOfEmpId { get; set; }
        public int? NoOfEmployees { get; set; }
        public int? NoOfContractEmp { get; set; }
        public int? NoOfExpatriates { get; set; }
        public int? StaffStrCompId { get; set; }
        public int? VenDepId { get; set; }

        public virtual TblStaffStrengthComp StaffStrComp { get; set; }
        public virtual TblVendorDepartments VenDep { get; set; }
    }
}
