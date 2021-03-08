using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblProducts
    {
        public TblProducts()
        {
            TblForeignCompany = new HashSet<TblForeignCompany>();
            TblForeignCompanyPerm = new HashSet<TblForeignCompanyPerm>();
            TblMainCustomers = new HashSet<TblMainCustomers>();
            TblMainCustomersPerm = new HashSet<TblMainCustomersPerm>();
            TblSupplierCategorization = new HashSet<TblSupplierCategorization>();
            TblSupplierCategorizationPerm = new HashSet<TblSupplierCategorizationPerm>();
            TblTypicalSubcontractedScope = new HashSet<TblTypicalSubcontractedScope>();
            TblTypicalSubcontractedScopePerm = new HashSet<TblTypicalSubcontractedScopePerm>();
        }

        public int ProductId { get; set; }
        public int? ProductCatId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual TblProductCategory ProductCat { get; set; }
        public virtual ICollection<TblForeignCompany> TblForeignCompany { get; set; }
        public virtual ICollection<TblForeignCompanyPerm> TblForeignCompanyPerm { get; set; }
        public virtual ICollection<TblMainCustomers> TblMainCustomers { get; set; }
        public virtual ICollection<TblMainCustomersPerm> TblMainCustomersPerm { get; set; }
        public virtual ICollection<TblSupplierCategorization> TblSupplierCategorization { get; set; }
        public virtual ICollection<TblSupplierCategorizationPerm> TblSupplierCategorizationPerm { get; set; }
        public virtual ICollection<TblTypicalSubcontractedScope> TblTypicalSubcontractedScope { get; set; }
        public virtual ICollection<TblTypicalSubcontractedScopePerm> TblTypicalSubcontractedScopePerm { get; set; }
    }
}
