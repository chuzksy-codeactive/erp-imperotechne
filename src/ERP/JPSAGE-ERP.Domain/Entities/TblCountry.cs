using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblCountry
    {
        public TblCountry()
        {
            TblEndUserRequisitionServices = new HashSet<TblEndUserRequisitionServices>();
            TblMainCustomers = new HashSet<TblMainCustomers>();
            TblMainCustomersPerm = new HashSet<TblMainCustomersPerm>();
            TblMtoelectricalFormDetails = new HashSet<TblMtoelectricalFormDetails>();
            TblMtoelectricalFormDetailsTemp = new HashSet<TblMtoelectricalFormDetailsTemp>();
            TblOfficeServiceClperm = new HashSet<TblOfficeServiceClperm>();
            TblSrconstructionTechnicalQueries = new HashSet<TblSrconstructionTechnicalQueries>();
            TblSrconstructionTechnicalQueriesTemp = new HashSet<TblSrconstructionTechnicalQueriesTemp>();
            TblSrnonConformanceReports = new HashSet<TblSrnonConformanceReports>();
            TblSrnonConformanceReportsTemp = new HashSet<TblSrnonConformanceReportsTemp>();
            TblStaffBioData = new HashSet<TblStaffBioData>();
            TblState = new HashSet<TblState>();
            TblSubContractorDetails = new HashSet<TblSubContractorDetails>();
            TblSupplierOwnership = new HashSet<TblSupplierOwnership>();
            TblSupplierOwnershipPerm = new HashSet<TblSupplierOwnershipPerm>();
            TblTypicalSubcontractedScope = new HashSet<TblTypicalSubcontractedScope>();
            TblTypicalSubcontractedScopePerm = new HashSet<TblTypicalSubcontractedScopePerm>();
        }

        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<TblEndUserRequisitionServices> TblEndUserRequisitionServices { get; set; }
        public virtual ICollection<TblMainCustomers> TblMainCustomers { get; set; }
        public virtual ICollection<TblMainCustomersPerm> TblMainCustomersPerm { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetails> TblMtoelectricalFormDetails { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetailsTemp> TblMtoelectricalFormDetailsTemp { get; set; }
        public virtual ICollection<TblOfficeServiceClperm> TblOfficeServiceClperm { get; set; }
        public virtual ICollection<TblSrconstructionTechnicalQueries> TblSrconstructionTechnicalQueries { get; set; }
        public virtual ICollection<TblSrconstructionTechnicalQueriesTemp> TblSrconstructionTechnicalQueriesTemp { get; set; }
        public virtual ICollection<TblSrnonConformanceReports> TblSrnonConformanceReports { get; set; }
        public virtual ICollection<TblSrnonConformanceReportsTemp> TblSrnonConformanceReportsTemp { get; set; }
        public virtual ICollection<TblStaffBioData> TblStaffBioData { get; set; }
        public virtual ICollection<TblState> TblState { get; set; }
        public virtual ICollection<TblSubContractorDetails> TblSubContractorDetails { get; set; }
        public virtual ICollection<TblSupplierOwnership> TblSupplierOwnership { get; set; }
        public virtual ICollection<TblSupplierOwnershipPerm> TblSupplierOwnershipPerm { get; set; }
        public virtual ICollection<TblTypicalSubcontractedScope> TblTypicalSubcontractedScope { get; set; }
        public virtual ICollection<TblTypicalSubcontractedScopePerm> TblTypicalSubcontractedScopePerm { get; set; }
    }
}
