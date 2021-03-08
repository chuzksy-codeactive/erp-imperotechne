using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblKnowledgeDgssystems
    {
        public int Kdgssid { get; set; }
        public string ContractNo { get; set; }
        public DateTime? StartDate { get; set; }
        public string Dgsref { get; set; }
        public int? ProvisionType { get; set; }
        public int? SupplierId { get; set; }
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }
        public int? EquipmentId { get; set; }

        public virtual TblEquipment Equipment { get; set; }
        public virtual TblProducts Product { get; set; }
        public virtual TblServices Service { get; set; }
        public virtual TblSupplierIdentification Supplier { get; set; }
    }
}
