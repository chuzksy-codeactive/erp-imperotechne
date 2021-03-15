using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMtoinstrumentFormDetails
    {
        public int InsFormDetId { get; set; }
        public string ItemDescription { get; set; }
        public int? MaterialId { get; set; }
        public int? Quantity { get; set; }
        public string MarkedUpQuantity { get; set; }
        public int? UnitToOrder { get; set; }
        public int? UnitId { get; set; }
        public int? ManufacturerId { get; set; }
        public string ModelNumber { get; set; }
        public string Comments { get; set; }
        public int? QuantityRequired { get; set; }
        public int? QuantitytoBuy { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? MtoformId { get; set; }

        public virtual TblManufacturers Manufacturer { get; set; }
        public virtual TblMaterials Material { get; set; }
        public virtual TblMtoforms Mtoform { get; set; }
        public virtual TblUnits Unit { get; set; }
    }
}
