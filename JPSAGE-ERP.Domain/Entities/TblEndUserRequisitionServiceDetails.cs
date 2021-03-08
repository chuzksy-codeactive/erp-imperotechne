using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblEndUserRequisitionServiceDetails
    {
        public int Eursdid { get; set; }
        public int Eursid { get; set; }
        public string Description { get; set; }
        public string ScopeOfWorks { get; set; }
        public string RefCodesStandards { get; set; }
        public string DetailedSpec { get; set; }
        public int? WorkScheduleType { get; set; }
        public int? WorkScheduleValue { get; set; }
        public string TechnicalEvalReq { get; set; }
        public string CommercialTemplate { get; set; }
        public int? PaymentTerms { get; set; }
        public DateTime? ValidityPeriod { get; set; }
        public string TermsConditions { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime? DeliveryDueDate { get; set; }
        public decimal? BudgetEstimate { get; set; }
        public decimal? TechnicalScore { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal? Renumeration { get; set; }

        public virtual TblEndUserRequisitionServices Eurs { get; set; }
    }
}
