using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblProductServiceCategory
    {
        public TblProductServiceCategory()
        {
            TblCategorySpecialization = new HashSet<TblCategorySpecialization>();
            TblSupplierCategorization = new HashSet<TblSupplierCategorization>();
            TblSupplierCategorizationPerm = new HashSet<TblSupplierCategorizationPerm>();
        }

        public int ProdServId { get; set; }
        public int? CategoryType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TblCategorySpecialization> TblCategorySpecialization { get; set; }
        public virtual ICollection<TblSupplierCategorization> TblSupplierCategorization { get; set; }
        public virtual ICollection<TblSupplierCategorizationPerm> TblSupplierCategorizationPerm { get; set; }
    }
}
