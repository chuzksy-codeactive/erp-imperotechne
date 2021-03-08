using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblProductCategory
    {
        public TblProductCategory()
        {
            TblProducts = new HashSet<TblProducts>();
            TblSupplierCategorization = new HashSet<TblSupplierCategorization>();
            TblSupplierCategorizationPerm = new HashSet<TblSupplierCategorizationPerm>();
        }

        public int ProductCatId { get; set; }
        public string ProductCatCode { get; set; }
        public string ProductCatName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? DprcatId { get; set; }

        public virtual TblDprcategory Dprcat { get; set; }
        public virtual ICollection<TblProducts> TblProducts { get; set; }
        public virtual ICollection<TblSupplierCategorization> TblSupplierCategorization { get; set; }
        public virtual ICollection<TblSupplierCategorizationPerm> TblSupplierCategorizationPerm { get; set; }
    }
}
