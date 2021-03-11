using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSubCategory
    {
        public TblSubCategory()
        {
            TblDirectServiceScope = new HashSet<TblDirectServiceScope>();
            TblDirectServiceScopePerm = new HashSet<TblDirectServiceScopePerm>();
        }

        public int SubCategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblDirectServiceScope> TblDirectServiceScope { get; set; }
        public virtual ICollection<TblDirectServiceScopePerm> TblDirectServiceScopePerm { get; set; }
    }
}
