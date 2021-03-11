using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSupplierCategorization
    {
        public int SupCatId { get; set; }
        public int SupplierId { get; set; }
        public int? ProductServiceCategoryId { get; set; }
        public int? CatSpecId { get; set; }
        public int? DprcatId { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? ServiceCategoryId { get; set; }
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual TblCategorySpecialization CatSpec { get; set; }
        public virtual TblDprcategory Dprcat { get; set; }
        public virtual TblProducts Product { get; set; }
        public virtual TblProductCategory ProductCategory { get; set; }
        public virtual TblProductServiceCategory ProductServiceCategory { get; set; }
        public virtual TblServices Service { get; set; }
        public virtual TblServicesCategory ServiceCategory { get; set; }
        public virtual TblSupplierIdentification Supplier { get; set; }
    }
}
