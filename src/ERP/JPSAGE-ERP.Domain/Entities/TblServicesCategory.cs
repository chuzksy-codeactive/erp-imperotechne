using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblServicesCategory
    {
        public TblServicesCategory()
        {
            TblServices = new HashSet<TblServices>();
            TblSupplierCategorization = new HashSet<TblSupplierCategorization>();
            TblSupplierCategorizationPerm = new HashSet<TblSupplierCategorizationPerm>();
        }

        public int ServCatId { get; set; }
        public string ServCatCode { get; set; }
        public string ServCatName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? DprcatId { get; set; }

        public virtual TblDprcategory Dprcat { get; set; }
        public virtual ICollection<TblServices> TblServices { get; set; }
        public virtual ICollection<TblSupplierCategorization> TblSupplierCategorization { get; set; }
        public virtual ICollection<TblSupplierCategorizationPerm> TblSupplierCategorizationPerm { get; set; }
    }
}
