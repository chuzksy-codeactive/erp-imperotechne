using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblCyMfgFfperm
    {
        public int CyMfgFfId { get; set; }
        public string Location { get; set; }
        public int? CityId { get; set; }
        public string PlantsEquipmentType { get; set; }
        public int? PlantsEquipmentNumber { get; set; }
        public string Utilization { get; set; }
        public decimal? FactoryArea { get; set; }
        public int? SupplierId { get; set; }

        public virtual TblCity City { get; set; }
        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
