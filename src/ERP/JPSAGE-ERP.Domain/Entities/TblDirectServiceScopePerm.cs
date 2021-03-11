using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblDirectServiceScopePerm
    {
        public int ServiceScopeId { get; set; }
        public string MaterialsName { get; set; }
        public int? SubCategoryId { get; set; }
        public int? SupplierId { get; set; }

        public virtual TblSubCategory SubCategory { get; set; }
        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
