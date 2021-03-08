using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblMtopipingFormDetailsTemp
    {
        public int PipFormDetId { get; set; }
        public int PipFormId { get; set; }
        public string Item { get; set; }
        public int? Size { get; set; }
        public string Schedule { get; set; }
        public int? Rating { get; set; }
        public string Description { get; set; }
        public int? ActualQuantityReq { get; set; }
        public decimal? Spare { get; set; }
        public int? TotalReq { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual TblMtopipingFormTemp PipForm { get; set; }
        public virtual TblUnits Unit { get; set; }
    }
}
