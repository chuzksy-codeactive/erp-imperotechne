using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblCategorySpecialization
    {
        public TblCategorySpecialization()
        {
            TblDprcategory = new HashSet<TblDprcategory>();
            TblSupplierCategorization = new HashSet<TblSupplierCategorization>();
            TblSupplierCategorizationPerm = new HashSet<TblSupplierCategorizationPerm>();
        }

        public int CatSpecId { get; set; }
        public int? ProdServId { get; set; }
        public int? SpecType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }

        public virtual TblProductServiceCategory ProdServ { get; set; }
        public virtual ICollection<TblDprcategory> TblDprcategory { get; set; }
        public virtual ICollection<TblSupplierCategorization> TblSupplierCategorization { get; set; }
        public virtual ICollection<TblSupplierCategorizationPerm> TblSupplierCategorizationPerm { get; set; }
    }
}
