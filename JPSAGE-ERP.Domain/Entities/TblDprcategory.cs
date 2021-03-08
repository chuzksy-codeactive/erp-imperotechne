using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblDprcategory
    {
        public TblDprcategory()
        {
            TblProductCategory = new HashSet<TblProductCategory>();
            TblServicesCategory = new HashSet<TblServicesCategory>();
            TblSupplierCategorization = new HashSet<TblSupplierCategorization>();
            TblSupplierCategorizationPerm = new HashSet<TblSupplierCategorizationPerm>();
        }

        public int DprcatId { get; set; }
        public int? CatSpecId { get; set; }
        public string DprcatCode { get; set; }
        public string DprcatName { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual TblCategorySpecialization CatSpec { get; set; }
        public virtual ICollection<TblProductCategory> TblProductCategory { get; set; }
        public virtual ICollection<TblServicesCategory> TblServicesCategory { get; set; }
        public virtual ICollection<TblSupplierCategorization> TblSupplierCategorization { get; set; }
        public virtual ICollection<TblSupplierCategorizationPerm> TblSupplierCategorizationPerm { get; set; }
    }
}
