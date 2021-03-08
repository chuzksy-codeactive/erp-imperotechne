using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblServices
    {
        public TblServices()
        {
            TblMainCustomers = new HashSet<TblMainCustomers>();
            TblMainCustomersPerm = new HashSet<TblMainCustomersPerm>();
            TblSpDirectServiceScope = new HashSet<TblSpDirectServiceScope>();
            TblSpDirectServiceScopePerm = new HashSet<TblSpDirectServiceScopePerm>();
            TblSubContractedServices = new HashSet<TblSubContractedServices>();
            TblSubContractedServicesPerm = new HashSet<TblSubContractedServicesPerm>();
            TblSupplierCategorization = new HashSet<TblSupplierCategorization>();
            TblSupplierCategorizationPerm = new HashSet<TblSupplierCategorizationPerm>();
        }

        public int ServiceId { get; set; }
        public int? ServCatId { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual TblServicesCategory ServCat { get; set; }
        public virtual ICollection<TblMainCustomers> TblMainCustomers { get; set; }
        public virtual ICollection<TblMainCustomersPerm> TblMainCustomersPerm { get; set; }
        public virtual ICollection<TblSpDirectServiceScope> TblSpDirectServiceScope { get; set; }
        public virtual ICollection<TblSpDirectServiceScopePerm> TblSpDirectServiceScopePerm { get; set; }
        public virtual ICollection<TblSubContractedServices> TblSubContractedServices { get; set; }
        public virtual ICollection<TblSubContractedServicesPerm> TblSubContractedServicesPerm { get; set; }
        public virtual ICollection<TblSupplierCategorization> TblSupplierCategorization { get; set; }
        public virtual ICollection<TblSupplierCategorizationPerm> TblSupplierCategorizationPerm { get; set; }
    }
}
