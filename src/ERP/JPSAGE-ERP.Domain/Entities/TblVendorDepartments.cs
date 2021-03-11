using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblVendorDepartments
    {
        public TblVendorDepartments()
        {
            TblNumberOfEmployees = new HashSet<TblNumberOfEmployees>();
            TblNumberOfEmployeesPerm = new HashSet<TblNumberOfEmployeesPerm>();
        }

        public int VenDepId { get; set; }
        public string VenDepCode { get; set; }
        public string VenDepTitle { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<TblNumberOfEmployees> TblNumberOfEmployees { get; set; }
        public virtual ICollection<TblNumberOfEmployeesPerm> TblNumberOfEmployeesPerm { get; set; }
    }
}
