using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMtoelectricalFormDetails
    {
        public int EleFormDetId { get; set; }
        public string ItemDescription { get; set; }
        public int? UnitId { get; set; }
        public int? QuantityRequired { get; set; }
        public int? QuantitytoBuy { get; set; }
        public decimal? Voltage { get; set; }
        public decimal? Weight { get; set; }
        public decimal? GlandSize { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? MtoformId { get; set; }

        public virtual TblCity City { get; set; }
        public virtual TblCountry Country { get; set; }
        public virtual TblMtoforms Mtoform { get; set; }
        public virtual TblState State { get; set; }
        public virtual TblUnits Unit { get; set; }
    }
}
