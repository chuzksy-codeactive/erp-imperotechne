using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblSupplierIdentification
    {
        public TblSupplierIdentification()
        {
            TblApproval = new HashSet<TblApproval>();
            TblBusinessExperience = new HashSet<TblBusinessExperience>();
            TblContactPersons = new HashSet<TblContactPersons>();
            TblCorpSocialResponsibility = new HashSet<TblCorpSocialResponsibility>();
            TblCorporateDistinctives = new HashSet<TblCorporateDistinctives>();
            TblCyMfgFf = new HashSet<TblCyMfgFf>();
            TblDirectServiceScope = new HashSet<TblDirectServiceScope>();
            TblFinancialAudits = new HashSet<TblFinancialAudits>();
            TblFinancialStatements = new HashSet<TblFinancialStatements>();
            TblForeignCompany = new HashSet<TblForeignCompany>();
            TblHealthSafetyEnvironment = new HashSet<TblHealthSafetyEnvironment>();
            TblHseCertification = new HashSet<TblHseCertification>();
            TblInvoice = new HashSet<TblInvoice>();
            TblJobCompletionCertificate = new HashSet<TblJobCompletionCertificate>();
            TblJustificationofAward = new HashSet<TblJustificationofAward>();
            TblMainCustomers = new HashSet<TblMainCustomers>();
            TblOfficeServiceCl = new HashSet<TblOfficeServiceCl>();
            TblPurchaseOrder = new HashSet<TblPurchaseOrder>();
            TblQualityCertification = new HashSet<TblQualityCertification>();
            TblQualityManagement = new HashSet<TblQualityManagement>();
            TblQuotationMaster = new HashSet<TblQuotationMaster>();
            TblSingleTenderJustification = new HashSet<TblSingleTenderJustification>();
            TblSpDirectServiceScope = new HashSet<TblSpDirectServiceScope>();
            TblSrnonConformanceReports = new HashSet<TblSrnonConformanceReports>();
            TblSrnonConformanceReportsTemp = new HashSet<TblSrnonConformanceReportsTemp>();
            TblStaffStrengthComp = new HashSet<TblStaffStrengthComp>();
            TblSubContractedServices = new HashSet<TblSubContractedServices>();
            TblSubContractorDetails = new HashSet<TblSubContractorDetails>();
            TblSubsidiaryCompany = new HashSet<TblSubsidiaryCompany>();
            TblSupplierCategorization = new HashSet<TblSupplierCategorization>();
            TblSupplierOwnership = new HashSet<TblSupplierOwnership>();
            TblSupplierProfile = new HashSet<TblSupplierProfile>();
            TblThirdPartyReference = new HashSet<TblThirdPartyReference>();
            TblTypicalSubcontractedScope = new HashSet<TblTypicalSubcontractedScope>();
            TblVendorProjectConsortium = new HashSet<TblVendorProjectConsortium>();
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

        public virtual TblFormIdentification Form { get; set; }
        public virtual ICollection<TblApproval> TblApproval { get; set; }
        public virtual ICollection<TblBusinessExperience> TblBusinessExperience { get; set; }
        public virtual ICollection<TblContactPersons> TblContactPersons { get; set; }
        public virtual ICollection<TblCorpSocialResponsibility> TblCorpSocialResponsibility { get; set; }
        public virtual ICollection<TblCorporateDistinctives> TblCorporateDistinctives { get; set; }
        public virtual ICollection<TblCyMfgFf> TblCyMfgFf { get; set; }
        public virtual ICollection<TblDirectServiceScope> TblDirectServiceScope { get; set; }
        public virtual ICollection<TblFinancialAudits> TblFinancialAudits { get; set; }
        public virtual ICollection<TblFinancialStatements> TblFinancialStatements { get; set; }
        public virtual ICollection<TblForeignCompany> TblForeignCompany { get; set; }
        public virtual ICollection<TblHealthSafetyEnvironment> TblHealthSafetyEnvironment { get; set; }
        public virtual ICollection<TblHseCertification> TblHseCertification { get; set; }
        public virtual ICollection<TblInvoice> TblInvoice { get; set; }
        public virtual ICollection<TblJobCompletionCertificate> TblJobCompletionCertificate { get; set; }
        public virtual ICollection<TblJustificationofAward> TblJustificationofAward { get; set; }
        public virtual ICollection<TblMainCustomers> TblMainCustomers { get; set; }
        public virtual ICollection<TblOfficeServiceCl> TblOfficeServiceCl { get; set; }
        public virtual ICollection<TblPurchaseOrder> TblPurchaseOrder { get; set; }
        public virtual ICollection<TblQualityCertification> TblQualityCertification { get; set; }
        public virtual ICollection<TblQualityManagement> TblQualityManagement { get; set; }
        public virtual ICollection<TblQuotationMaster> TblQuotationMaster { get; set; }
        public virtual ICollection<TblSingleTenderJustification> TblSingleTenderJustification { get; set; }
        public virtual ICollection<TblSpDirectServiceScope> TblSpDirectServiceScope { get; set; }
        public virtual ICollection<TblSrnonConformanceReports> TblSrnonConformanceReports { get; set; }
        public virtual ICollection<TblSrnonConformanceReportsTemp> TblSrnonConformanceReportsTemp { get; set; }
        public virtual ICollection<TblStaffStrengthComp> TblStaffStrengthComp { get; set; }
        public virtual ICollection<TblSubContractedServices> TblSubContractedServices { get; set; }
        public virtual ICollection<TblSubContractorDetails> TblSubContractorDetails { get; set; }
        public virtual ICollection<TblSubsidiaryCompany> TblSubsidiaryCompany { get; set; }
        public virtual ICollection<TblSupplierCategorization> TblSupplierCategorization { get; set; }
        public virtual ICollection<TblSupplierOwnership> TblSupplierOwnership { get; set; }
        public virtual ICollection<TblSupplierProfile> TblSupplierProfile { get; set; }
        public virtual ICollection<TblThirdPartyReference> TblThirdPartyReference { get; set; }
        public virtual ICollection<TblTypicalSubcontractedScope> TblTypicalSubcontractedScope { get; set; }
        public virtual ICollection<TblVendorProjectConsortium> TblVendorProjectConsortium { get; set; }
    }
}
