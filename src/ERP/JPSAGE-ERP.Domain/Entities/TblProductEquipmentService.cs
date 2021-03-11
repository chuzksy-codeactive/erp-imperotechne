using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblProductEquipmentService
    {
        public TblProductEquipmentService()
        {
            TblKnowledgeDgssystems = new HashSet<TblKnowledgeDgssystems>();
        }

        public int ProdEquSerId { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TblKnowledgeDgssystems> TblKnowledgeDgssystems { get; set; }
    }
}
