using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSupplierIdentificationPerm
    {
        public TblSupplierIdentificationPerm()
        {
            TblBusinessExperiencePerm = new HashSet<TblBusinessExperiencePerm>();
            TblContactPersonsPerm = new HashSet<TblContactPersonsPerm>();
            TblCorpSocialResponsibilityPerm = new HashSet<TblCorpSocialResponsibilityPerm>();
            TblCorporateDistinctivesPerm = new HashSet<TblCorporateDistinctivesPerm>();
            TblCyMfgFfperm = new HashSet<TblCyMfgFfperm>();
            TblDirectServiceScopePerm = new HashSet<TblDirectServiceScopePerm>();
            TblFinancialAuditsPerm = new HashSet<TblFinancialAuditsPerm>();
            TblFinancialStatementsPerm = new HashSet<TblFinancialStatementsPerm>();
            TblForeignCompanyPerm = new HashSet<TblForeignCompanyPerm>();
            TblHealthSafetyEnvironmentPerm = new HashSet<TblHealthSafetyEnvironmentPerm>();
            TblHseCertificationPerm = new HashSet<TblHseCertificationPerm>();
            TblMainCustomersPerm = new HashSet<TblMainCustomersPerm>();
            TblOfficeServiceClperm = new HashSet<TblOfficeServiceClperm>();
            TblQualityCertificationPerm = new HashSet<TblQualityCertificationPerm>();
            TblQualityManagementPerm = new HashSet<TblQualityManagementPerm>();
            TblSpDirectServiceScopePerm = new HashSet<TblSpDirectServiceScopePerm>();
            TblStaffStrengthCompPerm = new HashSet<TblStaffStrengthCompPerm>();
            TblSubContractedServicesPerm = new HashSet<TblSubContractedServicesPerm>();
            TblSubContractorDetailsPerm = new HashSet<TblSubContractorDetailsPerm>();
            TblSubsidiaryCompanyPerm = new HashSet<TblSubsidiaryCompanyPerm>();
            TblSupplierCategorizationPerm = new HashSet<TblSupplierCategorizationPerm>();
            TblSupplierOwnershipPerm = new HashSet<TblSupplierOwnershipPerm>();
            TblSupplierProfilePerm = new HashSet<TblSupplierProfilePerm>();
            TblThirdPartyReferencePerm = new HashSet<TblThirdPartyReferencePerm>();
            TblTypicalSubcontractedScopePerm = new HashSet<TblTypicalSubcontractedScopePerm>();
        }

        public int SupplierId { get; set; }
        public int FormId { get; set; }
        public string CompanyName { get; set; }
        public string HeadOfficeAddress { get; set; }
        public string CompanyRegNumber { get; set; }
        public string TaxClearanceCertificate { get; set; }
        public string BankReference { get; set; }
        public string CompanyProfile { get; set; }
        public string CompanyWebsiteUrl { get; set; }
        public string CorporateAffairsCommisionNo { get; set; }
        public bool? SupplierIsForeign { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DateofCreation { get; set; }

        public virtual TblFormIdentificationPerm Form { get; set; }
        public virtual ICollection<TblBusinessExperiencePerm> TblBusinessExperiencePerm { get; set; }
        public virtual ICollection<TblContactPersonsPerm> TblContactPersonsPerm { get; set; }
        public virtual ICollection<TblCorpSocialResponsibilityPerm> TblCorpSocialResponsibilityPerm { get; set; }
        public virtual ICollection<TblCorporateDistinctivesPerm> TblCorporateDistinctivesPerm { get; set; }
        public virtual ICollection<TblCyMfgFfperm> TblCyMfgFfperm { get; set; }
        public virtual ICollection<TblDirectServiceScopePerm> TblDirectServiceScopePerm { get; set; }
        public virtual ICollection<TblFinancialAuditsPerm> TblFinancialAuditsPerm { get; set; }
        public virtual ICollection<TblFinancialStatementsPerm> TblFinancialStatementsPerm { get; set; }
        public virtual ICollection<TblForeignCompanyPerm> TblForeignCompanyPerm { get; set; }
        public virtual ICollection<TblHealthSafetyEnvironmentPerm> TblHealthSafetyEnvironmentPerm { get; set; }
        public virtual ICollection<TblHseCertificationPerm> TblHseCertificationPerm { get; set; }
        public virtual ICollection<TblMainCustomersPerm> TblMainCustomersPerm { get; set; }
        public virtual ICollection<TblOfficeServiceClperm> TblOfficeServiceClperm { get; set; }
        public virtual ICollection<TblQualityCertificationPerm> TblQualityCertificationPerm { get; set; }
        public virtual ICollection<TblQualityManagementPerm> TblQualityManagementPerm { get; set; }
        public virtual ICollection<TblSpDirectServiceScopePerm> TblSpDirectServiceScopePerm { get; set; }
        public virtual ICollection<TblStaffStrengthCompPerm> TblStaffStrengthCompPerm { get; set; }
        public virtual ICollection<TblSubContractedServicesPerm> TblSubContractedServicesPerm { get; set; }
        public virtual ICollection<TblSubContractorDetailsPerm> TblSubContractorDetailsPerm { get; set; }
        public virtual ICollection<TblSubsidiaryCompanyPerm> TblSubsidiaryCompanyPerm { get; set; }
        public virtual ICollection<TblSupplierCategorizationPerm> TblSupplierCategorizationPerm { get; set; }
        public virtual ICollection<TblSupplierOwnershipPerm> TblSupplierOwnershipPerm { get; set; }
        public virtual ICollection<TblSupplierProfilePerm> TblSupplierProfilePerm { get; set; }
        public virtual ICollection<TblThirdPartyReferencePerm> TblThirdPartyReferencePerm { get; set; }
        public virtual ICollection<TblTypicalSubcontractedScopePerm> TblTypicalSubcontractedScopePerm { get; set; }
    }
}
