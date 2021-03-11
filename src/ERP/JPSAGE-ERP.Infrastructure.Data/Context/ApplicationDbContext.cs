using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using JPSAGE_ERP.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace JPSAGE_ERP.Domain
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        //public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        //public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        //public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        //public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BackgroundExecutor> BackgroundExecutor { get; set; }
        public virtual DbSet<BackgroundExecutorTrack> BackgroundExecutorTrack { get; set; }
        public virtual DbSet<BackgroundExecutorTrackingHistory> BackgroundExecutorTrackingHistory { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<TblActivityLog> TblActivityLog { get; set; }
        public virtual DbSet<TblApproval> TblApproval { get; set; }
        public virtual DbSet<TblAuthApprover> TblAuthApprover { get; set; }
        public virtual DbSet<TblAuthChecker> TblAuthChecker { get; set; }
        public virtual DbSet<TblAuthList> TblAuthList { get; set; }
        public virtual DbSet<TblBusinessExperience> TblBusinessExperience { get; set; }
        public virtual DbSet<TblBusinessExperiencePerm> TblBusinessExperiencePerm { get; set; }
        public virtual DbSet<TblCategorySpecialization> TblCategorySpecialization { get; set; }
        public virtual DbSet<TblCertifyingOrg> TblCertifyingOrg { get; set; }
        public virtual DbSet<TblCity> TblCity { get; set; }
        public virtual DbSet<TblClients> TblClients { get; set; }
        public virtual DbSet<TblCodeGenerator> TblCodeGenerator { get; set; }
        public virtual DbSet<TblCompanyInfo> TblCompanyInfo { get; set; }
        public virtual DbSet<TblCompanySubContractors> TblCompanySubContractors { get; set; }
        public virtual DbSet<TblContactPersons> TblContactPersons { get; set; }
        public virtual DbSet<TblContactPersonsPerm> TblContactPersonsPerm { get; set; }
        public virtual DbSet<TblCorpSocialResponsibility> TblCorpSocialResponsibility { get; set; }
        public virtual DbSet<TblCorpSocialResponsibilityPerm> TblCorpSocialResponsibilityPerm { get; set; }
        public virtual DbSet<TblCorporateDistinctives> TblCorporateDistinctives { get; set; }
        public virtual DbSet<TblCorporateDistinctivesPerm> TblCorporateDistinctivesPerm { get; set; }
        public virtual DbSet<TblCountry> TblCountry { get; set; }
        public virtual DbSet<TblCurrency> TblCurrency { get; set; }
        public virtual DbSet<TblCyMfgFf> TblCyMfgFf { get; set; }
        public virtual DbSet<TblCyMfgFfperm> TblCyMfgFfperm { get; set; }
        public virtual DbSet<TblDatabaseObjects> TblDatabaseObjects { get; set; }
        public virtual DbSet<TblDepartments> TblDepartments { get; set; }
        public virtual DbSet<TblDirectServiceScope> TblDirectServiceScope { get; set; }
        public virtual DbSet<TblDirectServiceScopePerm> TblDirectServiceScopePerm { get; set; }
        public virtual DbSet<TblDocumentType> TblDocumentType { get; set; }
        public virtual DbSet<TblDprcategory> TblDprcategory { get; set; }
        public virtual DbSet<TblEndUserRequisitionProducts> TblEndUserRequisitionProducts { get; set; }
        public virtual DbSet<TblEndUserRequisitionProductsDeliveryInfo> TblEndUserRequisitionProductsDeliveryInfo { get; set; }
        public virtual DbSet<TblEndUserRequisitionProductsDetails> TblEndUserRequisitionProductsDetails { get; set; }
        public virtual DbSet<TblEndUserRequisitionProductsMto> TblEndUserRequisitionProductsMto { get; set; }
        public virtual DbSet<TblEndUserRequisitionProductsOtherInfo> TblEndUserRequisitionProductsOtherInfo { get; set; }
        public virtual DbSet<TblEndUserRequisitionServiceAttachments> TblEndUserRequisitionServiceAttachments { get; set; }
        public virtual DbSet<TblEndUserRequisitionServiceDetails> TblEndUserRequisitionServiceDetails { get; set; }
        public virtual DbSet<TblEndUserRequisitionServices> TblEndUserRequisitionServices { get; set; }
        public virtual DbSet<TblEndUserRequisitionServicesMto> TblEndUserRequisitionServicesMto { get; set; }
        public virtual DbSet<TblEquipment> TblEquipment { get; set; }
        public virtual DbSet<TblEventDetails> TblEventDetails { get; set; }
        public virtual DbSet<TblEventOtherInfo> TblEventOtherInfo { get; set; }
        public virtual DbSet<TblEvents> TblEvents { get; set; }
        public virtual DbSet<TblFinancialAudits> TblFinancialAudits { get; set; }
        public virtual DbSet<TblFinancialAuditsPerm> TblFinancialAuditsPerm { get; set; }
        public virtual DbSet<TblFinancialStatements> TblFinancialStatements { get; set; }
        public virtual DbSet<TblFinancialStatementsPerm> TblFinancialStatementsPerm { get; set; }
        public virtual DbSet<TblForeignCompany> TblForeignCompany { get; set; }
        public virtual DbSet<TblForeignCompanyPerm> TblForeignCompanyPerm { get; set; }
        public virtual DbSet<TblFormIdentification> TblFormIdentification { get; set; }
        public virtual DbSet<TblFormIdentificationPerm> TblFormIdentificationPerm { get; set; }
        public virtual DbSet<TblForms> TblForms { get; set; }
        public virtual DbSet<TblHealthSafetyEnvironment> TblHealthSafetyEnvironment { get; set; }
        public virtual DbSet<TblHealthSafetyEnvironmentPerm> TblHealthSafetyEnvironmentPerm { get; set; }
        public virtual DbSet<TblHoliday> TblHoliday { get; set; }
        public virtual DbSet<TblHseCertification> TblHseCertification { get; set; }
        public virtual DbSet<TblHseCertificationPerm> TblHseCertificationPerm { get; set; }
        public virtual DbSet<TblInvoice> TblInvoice { get; set; }
        public virtual DbSet<TblInvoiceDetails> TblInvoiceDetails { get; set; }
        public virtual DbSet<TblInvoiceOtherInfo> TblInvoiceOtherInfo { get; set; }
        public virtual DbSet<TblJobCompletionCertificate> TblJobCompletionCertificate { get; set; }
        public virtual DbSet<TblJustificationofAward> TblJustificationofAward { get; set; }
        public virtual DbSet<TblLog> TblLog { get; set; }
        public virtual DbSet<TblMainCustomers> TblMainCustomers { get; set; }
        public virtual DbSet<TblMainCustomersPerm> TblMainCustomersPerm { get; set; }
        public virtual DbSet<TblManufacturers> TblManufacturers { get; set; }
        public virtual DbSet<TblMaterials> TblMaterials { get; set; }
        public virtual DbSet<TblMtocivilForm> TblMtocivilForm { get; set; }
        public virtual DbSet<TblMtocivilFormDetails> TblMtocivilFormDetails { get; set; }
        public virtual DbSet<TblMtocivilFormDetailsTemp> TblMtocivilFormDetailsTemp { get; set; }
        public virtual DbSet<TblMtocivilFormTemp> TblMtocivilFormTemp { get; set; }
        public virtual DbSet<TblMtodiscipline> TblMtodiscipline { get; set; }
        public virtual DbSet<TblMtoelectricalForm> TblMtoelectricalForm { get; set; }
        public virtual DbSet<TblMtoelectricalFormDetails> TblMtoelectricalFormDetails { get; set; }
        public virtual DbSet<TblMtoelectricalFormDetailsTemp> TblMtoelectricalFormDetailsTemp { get; set; }
        public virtual DbSet<TblMtoelectricalFormTemp> TblMtoelectricalFormTemp { get; set; }
        public virtual DbSet<TblMtoinstrumentForm> TblMtoinstrumentForm { get; set; }
        public virtual DbSet<TblMtoinstrumentFormDetails> TblMtoinstrumentFormDetails { get; set; }
        public virtual DbSet<TblMtoinstrumentFormDetailsTemp> TblMtoinstrumentFormDetailsTemp { get; set; }
        public virtual DbSet<TblMtoinstrumentFormTemp> TblMtoinstrumentFormTemp { get; set; }
        public virtual DbSet<TblMtopipingForm> TblMtopipingForm { get; set; }
        public virtual DbSet<TblMtopipingFormDetails> TblMtopipingFormDetails { get; set; }
        public virtual DbSet<TblMtopipingFormDetailsTemp> TblMtopipingFormDetailsTemp { get; set; }
        public virtual DbSet<TblMtopipingFormTemp> TblMtopipingFormTemp { get; set; }
        public virtual DbSet<TblMtosubDiscipline> TblMtosubDiscipline { get; set; }
        public virtual DbSet<TblNotificationGroup> TblNotificationGroup { get; set; }
        public virtual DbSet<TblNumberOfEmployees> TblNumberOfEmployees { get; set; }
        public virtual DbSet<TblNumberOfEmployeesPerm> TblNumberOfEmployeesPerm { get; set; }
        public virtual DbSet<TblOfficeServiceCl> TblOfficeServiceCl { get; set; }
        public virtual DbSet<TblOfficeServiceClperm> TblOfficeServiceClperm { get; set; }
        public virtual DbSet<TblPaymentBank> TblPaymentBank { get; set; }
        public virtual DbSet<TblPaymentRequestDetails> TblPaymentRequestDetails { get; set; }
        public virtual DbSet<TblPaymentRequestMaster> TblPaymentRequestMaster { get; set; }
        public virtual DbSet<TblPosition> TblPosition { get; set; }
        public virtual DbSet<TblProductCategory> TblProductCategory { get; set; }
        public virtual DbSet<TblProductServiceCategory> TblProductServiceCategory { get; set; }
        public virtual DbSet<TblProducts> TblProducts { get; set; }
        public virtual DbSet<TblProjects> TblProjects { get; set; }
        public virtual DbSet<TblPurchaseOrder> TblPurchaseOrder { get; set; }
        public virtual DbSet<TblPurchaseOrderDetails> TblPurchaseOrderDetails { get; set; }
        public virtual DbSet<TblPurchaseOrderMilestones> TblPurchaseOrderMilestones { get; set; }
        public virtual DbSet<TblQualityCertification> TblQualityCertification { get; set; }
        public virtual DbSet<TblQualityCertificationPerm> TblQualityCertificationPerm { get; set; }
        public virtual DbSet<TblQualityManagement> TblQualityManagement { get; set; }
        public virtual DbSet<TblQualityManagementPerm> TblQualityManagementPerm { get; set; }
        public virtual DbSet<TblQuotationApproval> TblQuotationApproval { get; set; }
        public virtual DbSet<TblQuotationDeliveryInfo> TblQuotationDeliveryInfo { get; set; }
        public virtual DbSet<TblQuotationDetails> TblQuotationDetails { get; set; }
        public virtual DbSet<TblQuotationMaster> TblQuotationMaster { get; set; }
        public virtual DbSet<TblQuotationOtherInfo> TblQuotationOtherInfo { get; set; }
        public virtual DbSet<TblQuotationOtherInfoAttachments> TblQuotationOtherInfoAttachments { get; set; }
        public virtual DbSet<TblServices> TblServices { get; set; }
        public virtual DbSet<TblServicesCategory> TblServicesCategory { get; set; }
        public virtual DbSet<TblSingleTenderJustification> TblSingleTenderJustification { get; set; }
        public virtual DbSet<TblSpDirectServiceScope> TblSpDirectServiceScope { get; set; }
        public virtual DbSet<TblSpDirectServiceScopePerm> TblSpDirectServiceScopePerm { get; set; }
        public virtual DbSet<TblSrconstructionTechnicalQueries> TblSrconstructionTechnicalQueries { get; set; }
        public virtual DbSet<TblSrconstructionTechnicalQueriesTemp> TblSrconstructionTechnicalQueriesTemp { get; set; }
        public virtual DbSet<TblSrconstructionTechnicalQueryAttachments> TblSrconstructionTechnicalQueryAttachments { get; set; }
        public virtual DbSet<TblSrconstructionTechnicalQueryAttachmentsTemp> TblSrconstructionTechnicalQueryAttachmentsTemp { get; set; }
        public virtual DbSet<TblSrconstructionTechnicalQueryReplies> TblSrconstructionTechnicalQueryReplies { get; set; }
        public virtual DbSet<TblSrconstructionTechnicalQueryRepliesTemp> TblSrconstructionTechnicalQueryRepliesTemp { get; set; }
        public virtual DbSet<TblSrdailyReportHse> TblSrdailyReportHse { get; set; }
        public virtual DbSet<TblSrdailyReportHseattachments> TblSrdailyReportHseattachments { get; set; }
        public virtual DbSet<TblSrdailyReportHseattachmentsTemp> TblSrdailyReportHseattachmentsTemp { get; set; }
        public virtual DbSet<TblSrdailyReportHsetemp> TblSrdailyReportHsetemp { get; set; }
        public virtual DbSet<TblSrdailyReportOtherSiteReports> TblSrdailyReportOtherSiteReports { get; set; }
        public virtual DbSet<TblSrdailyReportOtherSiteReportsTemp> TblSrdailyReportOtherSiteReportsTemp { get; set; }
        public virtual DbSet<TblSrdailyReportProgressMeasurementDetails> TblSrdailyReportProgressMeasurementDetails { get; set; }
        public virtual DbSet<TblSrdailyReportProgressMeasurementDetailsTemp> TblSrdailyReportProgressMeasurementDetailsTemp { get; set; }
        public virtual DbSet<TblSrdailyReportProgressMeasurementMaster> TblSrdailyReportProgressMeasurementMaster { get; set; }
        public virtual DbSet<TblSrdailyReportProgressMeasurementMasterTemp> TblSrdailyReportProgressMeasurementMasterTemp { get; set; }
        public virtual DbSet<TblSrdailyReportingConstructionActivities> TblSrdailyReportingConstructionActivities { get; set; }
        public virtual DbSet<TblSrdailyReportingConstructionActivitiesTemp> TblSrdailyReportingConstructionActivitiesTemp { get; set; }
        public virtual DbSet<TblSrdailyReportingDelays> TblSrdailyReportingDelays { get; set; }
        public virtual DbSet<TblSrdailyReportingDelaysTemp> TblSrdailyReportingDelaysTemp { get; set; }
        public virtual DbSet<TblSrdailyReportingGenSumAttachments> TblSrdailyReportingGenSumAttachments { get; set; }
        public virtual DbSet<TblSrdailyReportingGenSumAttachmentsTemp> TblSrdailyReportingGenSumAttachmentsTemp { get; set; }
        public virtual DbSet<TblSrdailyReportingGeneralSummary> TblSrdailyReportingGeneralSummary { get; set; }
        public virtual DbSet<TblSrdailyReportingGeneralSummaryTemp> TblSrdailyReportingGeneralSummaryTemp { get; set; }
        public virtual DbSet<TblSrdailyReportingIssues> TblSrdailyReportingIssues { get; set; }
        public virtual DbSet<TblSrdailyReportingIssuesTemp> TblSrdailyReportingIssuesTemp { get; set; }
        public virtual DbSet<TblSrdailyReportingProgressPictures> TblSrdailyReportingProgressPictures { get; set; }
        public virtual DbSet<TblSrdailyReportingProgressPicturesTemp> TblSrdailyReportingProgressPicturesTemp { get; set; }
        public virtual DbSet<TblSrdrprogressPicturesAttachments> TblSrdrprogressPicturesAttachments { get; set; }
        public virtual DbSet<TblSrdrprogressPicturesAttachmentsTemp> TblSrdrprogressPicturesAttachmentsTemp { get; set; }
        public virtual DbSet<TblSrncrattachments> TblSrncrattachments { get; set; }
        public virtual DbSet<TblSrncrattachmentsTemp> TblSrncrattachmentsTemp { get; set; }
        public virtual DbSet<TblSrnonConformanceReports> TblSrnonConformanceReports { get; set; }
        public virtual DbSet<TblSrnonConformanceReportsTemp> TblSrnonConformanceReportsTemp { get; set; }
        public virtual DbSet<TblStaffBioData> TblStaffBioData { get; set; }
        public virtual DbSet<TblStaffRoles> TblStaffRoles { get; set; }
        public virtual DbSet<TblStaffStrengthComp> TblStaffStrengthComp { get; set; }
        public virtual DbSet<TblStaffStrengthCompPerm> TblStaffStrengthCompPerm { get; set; }
        public virtual DbSet<TblState> TblState { get; set; }
        public virtual DbSet<TblSubCategory> TblSubCategory { get; set; }
        public virtual DbSet<TblSubContractedServices> TblSubContractedServices { get; set; }
        public virtual DbSet<TblSubContractedServicesPerm> TblSubContractedServicesPerm { get; set; }
        public virtual DbSet<TblSubContractorDetails> TblSubContractorDetails { get; set; }
        public virtual DbSet<TblSubContractorDetailsPerm> TblSubContractorDetailsPerm { get; set; }
        public virtual DbSet<TblSubsidiaryCompany> TblSubsidiaryCompany { get; set; }
        public virtual DbSet<TblSubsidiaryCompanyPerm> TblSubsidiaryCompanyPerm { get; set; }
        public virtual DbSet<TblSupplierCategorization> TblSupplierCategorization { get; set; }
        public virtual DbSet<TblSupplierCategorizationPerm> TblSupplierCategorizationPerm { get; set; }
        public virtual DbSet<TblSupplierIdentification> TblSupplierIdentification { get; set; }
        public virtual DbSet<TblSupplierIdentificationPerm> TblSupplierIdentificationPerm { get; set; }
        public virtual DbSet<TblSupplierOwnership> TblSupplierOwnership { get; set; }
        public virtual DbSet<TblSupplierOwnershipPerm> TblSupplierOwnershipPerm { get; set; }
        public virtual DbSet<TblSupplierProfile> TblSupplierProfile { get; set; }
        public virtual DbSet<TblSupplierProfilePerm> TblSupplierProfilePerm { get; set; }
        public virtual DbSet<TblTenderAttachements> TblTenderAttachements { get; set; }
        public virtual DbSet<TblThirdPartyReference> TblThirdPartyReference { get; set; }
        public virtual DbSet<TblThirdPartyReferencePerm> TblThirdPartyReferencePerm { get; set; }
        public virtual DbSet<TblTypicalSubcontractedScope> TblTypicalSubcontractedScope { get; set; }
        public virtual DbSet<TblTypicalSubcontractedScopePerm> TblTypicalSubcontractedScopePerm { get; set; }
        public virtual DbSet<TblUnits> TblUnits { get; set; }
        public virtual DbSet<TblVendorData> TblVendorData { get; set; }
        public virtual DbSet<TblVendorDepartments> TblVendorDepartments { get; set; }
        public virtual DbSet<TblVendorPositions> TblVendorPositions { get; set; }
        public virtual DbSet<TblVendorProjectConsortium> TblVendorProjectConsortium { get; set; }
        public virtual DbSet<TblVendorRegFormApproval> TblVendorRegFormApproval { get; set; }
        public virtual DbSet<TblWorkflowProcessDef> TblWorkflowProcessDef { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = "2", Name = "Checker", NormalizedName = "CHECKER" },
                new { Id = "3", Name = "Authorizer", NormalizedName = "AUTHORIZER" },
                new { Id = "4", Name = "Staff", NormalizedName = "STAFF" },
                new { Id = "5", Name = "VendorAdmin", NormalizedName = "VENDORADMIN" },
                new { Id = "6", Name = "Vendor", NormalizedName = "VENDOR" }
                );

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<BackgroundExecutor>(entity =>
            {
                entity.ToTable("Background_executor");

                entity.HasIndex(e => e.BackgroundSp)
                    .HasName("UK_Background_executor")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BackgroundSp)
                    .IsRequired()
                    .HasColumnName("background_sp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RunRank).HasColumnName("run_rank");
            });

            modelBuilder.Entity<BackgroundExecutorTrack>(entity =>
            {
                entity.ToTable("Background_executor_track");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProcName)
                    .IsRequired()
                    .HasColumnName("procName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RunError)
                    .HasColumnName("run_error")
                    .IsUnicode(false);

                entity.Property(e => e.RunTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BackgroundExecutorTrackingHistory>(entity =>
            {
                entity.ToTable("Background_executor_tracking_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasColumnName("batch_id")
                    .HasMaxLength(100);

                entity.Property(e => e.ProcName)
                    .IsRequired()
                    .HasColumnName("proc_name")
                    .HasMaxLength(100);

                entity.Property(e => e.TTime)
                    .HasColumnName("t_time")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeEnd)
                    .HasColumnName("time_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStart)
                    .HasColumnName("time_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("transaction_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key)
                    .HasName("CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score })
                    .HasName("IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<TblActivityLog>(entity =>
            {
                entity.HasKey(e => e.ActivityLogId);

                entity.ToTable("tbl_ActivityLog");

                entity.Property(e => e.ActivityLogId).HasColumnName("ActivityLogID");

                entity.Property(e => e.ApprovedBy).HasMaxLength(200);

                entity.Property(e => e.CheckedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.InitiatedBy).HasMaxLength(200);

                entity.Property(e => e.ProcessName).HasMaxLength(200);
            });

            modelBuilder.Entity<TblApproval>(entity =>
            {
                entity.HasKey(e => e.ApprovalId);

                entity.ToTable("tbl_Approval");

                entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnName("Approval_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblApproval)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Approval_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblAuthApprover>(entity =>
            {
                entity.HasKey(e => e.AuthAppId);

                entity.ToTable("tbl_AuthApprover");

                entity.Property(e => e.AuthAppId).HasColumnName("AuthAppID");

                entity.Property(e => e.AuthId).HasColumnName("AuthID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reason).HasMaxLength(1000);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.HasOne(d => d.Auth)
                    .WithMany(p => p.TblAuthApprover)
                    .HasForeignKey(d => d.AuthId)
                    .HasConstraintName("FK_tbl_AuthApprover_tbl_AuthList");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TblAuthApprover)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_tbl_AuthApprover_tbl_StaffBioData");
            });

            modelBuilder.Entity<TblAuthChecker>(entity =>
            {
                entity.HasKey(e => e.AuthChId);

                entity.ToTable("tbl_AuthChecker");

                entity.Property(e => e.AuthChId).HasColumnName("AuthChID");

                entity.Property(e => e.AuthId).HasColumnName("AuthID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reason).HasMaxLength(1000);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.HasOne(d => d.Auth)
                    .WithMany(p => p.TblAuthChecker)
                    .HasForeignKey(d => d.AuthId)
                    .HasConstraintName("FK_tbl_AuthChecker_tbl_AuthList");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TblAuthChecker)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_tbl_AuthChecker_tbl_StaffBioData");
            });

            modelBuilder.Entity<TblAuthList>(entity =>
            {
                entity.HasKey(e => e.AuthId);

                entity.ToTable("tbl_AuthList");

                entity.Property(e => e.AuthId).HasColumnName("AuthID");

                entity.Property(e => e.ApproverStatusReason).HasMaxLength(1000);

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasColumnName("BatchID")
                    .HasMaxLength(100);

                entity.Property(e => e.CheckerStatusReason).HasMaxLength(1000);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StatusReason).HasMaxLength(1000);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(100);

                entity.Property(e => e.WfdefId).HasColumnName("WFDefID");
            });

            modelBuilder.Entity<TblBusinessExperience>(entity =>
            {
                entity.HasKey(e => e.BizExId);

                entity.ToTable("tbl_BusinessExperience");

                entity.Property(e => e.BizExId).HasColumnName("BizExID");

                entity.Property(e => e.CompanyWorkedWith).HasMaxLength(100);

                entity.Property(e => e.ContractNumber).HasMaxLength(50);

                entity.Property(e => e.DemobilizationDate).HasColumnType("datetime");

                entity.Property(e => e.MobilizationDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.ScopeCovered).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblBusinessExperience)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_BusinessExperience_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblBusinessExperiencePerm>(entity =>
            {
                entity.HasKey(e => e.BizExId);

                entity.ToTable("tbl_BusinessExperiencePerm");

                entity.Property(e => e.BizExId).HasColumnName("BizExID");

                entity.Property(e => e.CompanyWorkedWith).HasMaxLength(100);

                entity.Property(e => e.ContractNumber).HasMaxLength(50);

                entity.Property(e => e.DemobilizationDate).HasColumnType("datetime");

                entity.Property(e => e.MobilizationDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.ScopeCovered).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblBusinessExperiencePerm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_BusinessExperiencePerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblCategorySpecialization>(entity =>
            {
                entity.HasKey(e => e.CatSpecId);

                entity.ToTable("tbl_CategorySpecialization");

                entity.Property(e => e.CatSpecId).HasColumnName("CatSpecID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ProdServId).HasColumnName("ProdServID");

                entity.HasOne(d => d.ProdServ)
                    .WithMany(p => p.TblCategorySpecialization)
                    .HasForeignKey(d => d.ProdServId)
                    .HasConstraintName("FK_tbl_CategorySpecialization_tbl_ProductServiceCategory");
            });

            modelBuilder.Entity<TblCertifyingOrg>(entity =>
            {
                entity.HasKey(e => e.CertOrgId);

                entity.ToTable("tbl_CertifyingOrg");

                entity.Property(e => e.CertOrgId).HasColumnName("CertOrgID");

                entity.Property(e => e.CertOrgName).HasMaxLength(500);
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("tbl_City");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblCity)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_City_tbl_State");
            });

            modelBuilder.Entity<TblClients>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.ToTable("tbl_Clients");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.ClientCode).HasMaxLength(10);

                entity.Property(e => e.ClientLogo).HasColumnType("image");

                entity.Property(e => e.ClientName).HasMaxLength(200);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber1).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.Property(e => e.WebSiteUrl)
                    .HasColumnName("WebSiteURL")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblClients)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_Clients_tbl_CompanyInfo");
            });

            modelBuilder.Entity<TblCodeGenerator>(entity =>
            {
                entity.HasKey(e => e.CodeGenId);

                entity.ToTable("tbl_CodeGenerator");

                entity.Property(e => e.CodeGenId).HasColumnName("CodeGenID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GeneratedCode).HasMaxLength(100);
            });

            modelBuilder.Entity<TblCompanyInfo>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("tbl_CompanyInfo");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CompanyCode).HasMaxLength(10);

                entity.Property(e => e.CompanyLogo).HasColumnType("image");

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber1).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.WebsiteUrl)
                    .HasColumnName("WebsiteURL")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblCompanyInfo)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_CompanyInfo_tbl_Projects");
            });

            modelBuilder.Entity<TblCompanySubContractors>(entity =>
            {
                entity.HasKey(e => e.ComSubConId);

                entity.ToTable("tbl_CompanySubContractors");

                entity.Property(e => e.ComSubConId).HasColumnName("ComSubConID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SubContractorAddress).HasMaxLength(500);

                entity.Property(e => e.SubContractorName).HasMaxLength(200);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblCompanySubContractors)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_CompanySubContractors_tbl_CompanyInfo");
            });

            modelBuilder.Entity<TblContactPersons>(entity =>
            {
                entity.HasKey(e => e.ContactPersonId);

                entity.ToTable("tbl_ContactPersons");

                entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");

                entity.Property(e => e.ContactPersonName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.VenPosId).HasColumnName("VenPosID");

                entity.Property(e => e.WorkPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.TblContactPersons)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_tbl_ContactPersons_tbl_FormIdentification");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblContactPersons)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_ContactPersons_tbl_SupplierIdentification");

                entity.HasOne(d => d.VenPos)
                    .WithMany(p => p.TblContactPersons)
                    .HasForeignKey(d => d.VenPosId)
                    .HasConstraintName("FK_tbl_ContactPersons_tbl_VendorPositions");
            });

            modelBuilder.Entity<TblContactPersonsPerm>(entity =>
            {
                entity.HasKey(e => e.ContactPersonId);

                entity.ToTable("tbl_ContactPersonsPerm");

                entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");

                entity.Property(e => e.ContactPersonName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.VenPosId).HasColumnName("VenPosID");

                entity.Property(e => e.WorkPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.TblContactPersonsPerm)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_tbl_ContactPersonsPerm_tbl_FormIdentificationPerm");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblContactPersonsPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_ContactPersonsPerm_tbl_SupplierIdentificationPerm");

                entity.HasOne(d => d.VenPos)
                    .WithMany(p => p.TblContactPersonsPerm)
                    .HasForeignKey(d => d.VenPosId)
                    .HasConstraintName("FK_tbl_ContactPersonsPerm_tbl_VendorPositions");
            });

            modelBuilder.Entity<TblCorpSocialResponsibility>(entity =>
            {
                entity.HasKey(e => e.CsrId);

                entity.ToTable("tbl_CorpSocialResponsibility");

                entity.Property(e => e.CsrId).HasColumnName("CSR_ID");

                entity.Property(e => e.SrethHumanLaborLaws).HasColumnName("SREthHumanLaborLaws");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblCorpSocialResponsibility)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CorpSocialResponsibility_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblCorpSocialResponsibilityPerm>(entity =>
            {
                entity.HasKey(e => e.CsrId);

                entity.ToTable("tbl_CorpSocialResponsibilityPerm");

                entity.Property(e => e.CsrId).HasColumnName("CSR_ID");

                entity.Property(e => e.SrethHumanLaborLaws).HasColumnName("SREthHumanLaborLaws");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblCorpSocialResponsibilityPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CorpSocialResponsibilityPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblCorporateDistinctives>(entity =>
            {
                entity.HasKey(e => e.CorpDisId);

                entity.ToTable("tbl_CorporateDistinctives");

                entity.Property(e => e.CorpDisId).HasColumnName("CorpDisID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblCorporateDistinctives)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CorporateDistinctives_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblCorporateDistinctivesPerm>(entity =>
            {
                entity.HasKey(e => e.CorpDisId);

                entity.ToTable("tbl_CorporateDistinctivesPerm");

                entity.Property(e => e.CorpDisId).HasColumnName("CorpDisID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblCorporateDistinctivesPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CorporateDistinctivesPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("tbl_Country");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.ToTable("tbl_Currency");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyCode).HasMaxLength(5);

                entity.Property(e => e.CurrencyName).HasMaxLength(50);

                entity.Property(e => e.CurrencySymbol).HasMaxLength(5);
            });

            modelBuilder.Entity<TblCyMfgFf>(entity =>
            {
                entity.HasKey(e => e.CyMfgFfId);

                entity.ToTable("tbl_CY_MFG_FF");

                entity.Property(e => e.CyMfgFfId).HasColumnName("CY_MFG_FF_ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.FactoryArea).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Location).HasMaxLength(500);

                entity.Property(e => e.PlantsEquipmentType).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Utilization).HasMaxLength(500);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblCyMfgFf)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_CY_MFG_FF_tbl_City");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblCyMfgFf)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_CY_MFG_FF_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblCyMfgFfperm>(entity =>
            {
                entity.HasKey(e => e.CyMfgFfId);

                entity.ToTable("tbl_CY_MFG_FFPerm");

                entity.Property(e => e.CyMfgFfId).HasColumnName("CY_MFG_FF_ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.FactoryArea).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Location).HasMaxLength(500);

                entity.Property(e => e.PlantsEquipmentType).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Utilization).HasMaxLength(500);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblCyMfgFfperm)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_CY_MFG_FFPerm_tbl_City");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblCyMfgFfperm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_CY_MFG_FFPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblDatabaseObjects>(entity =>
            {
                entity.HasKey(e => e.DbobjId);

                entity.ToTable("tbl_DatabaseObjects");

                entity.Property(e => e.DbobjId).HasColumnName("DBObjID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Parameters).HasMaxLength(500);
            });

            modelBuilder.Entity<TblDepartments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("tbl_Departments");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(10);

                entity.Property(e => e.DepartmentEmailAddress).HasMaxLength(100);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblDepartments)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_Departments_tbl_CompanyInfo");
            });

            modelBuilder.Entity<TblDirectServiceScope>(entity =>
            {
                entity.HasKey(e => e.ServiceScopeId);

                entity.ToTable("tbl_DirectServiceScope");

                entity.Property(e => e.ServiceScopeId).HasColumnName("ServiceScopeID");

                entity.Property(e => e.MaterialsName).HasMaxLength(500);

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.TblDirectServiceScope)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_tbl_DirectServiceScope_tbl_SubCategory");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblDirectServiceScope)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_DirectServiceScope_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblDirectServiceScopePerm>(entity =>
            {
                entity.HasKey(e => e.ServiceScopeId);

                entity.ToTable("tbl_DirectServiceScopePerm");

                entity.Property(e => e.ServiceScopeId).HasColumnName("ServiceScopeID");

                entity.Property(e => e.MaterialsName).HasMaxLength(500);

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.TblDirectServiceScopePerm)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_tbl_DirectServiceScopePerm_tbl_SubCategory");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblDirectServiceScopePerm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_DirectServiceScopePerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblDocumentType>(entity =>
            {
                entity.HasKey(e => e.DocTypeId);

                entity.ToTable("tbl_DocumentType");

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocTypeDescription).HasMaxLength(500);

                entity.Property(e => e.DocTypeName).HasMaxLength(20);
            });

            modelBuilder.Entity<TblDprcategory>(entity =>
            {
                entity.HasKey(e => e.DprcatId);

                entity.ToTable("tbl_DPRCategory");

                entity.Property(e => e.DprcatId).HasColumnName("DPRCatID");

                entity.Property(e => e.CatSpecId).HasColumnName("CatSpecID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DprcatCode)
                    .HasColumnName("DPRCatCode")
                    .HasMaxLength(10);

                entity.Property(e => e.DprcatName)
                    .HasColumnName("DPRCatName")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CatSpec)
                    .WithMany(p => p.TblDprcategory)
                    .HasForeignKey(d => d.CatSpecId)
                    .HasConstraintName("FK_tbl_DPRCategory_tbl_CategorySpecialization");
            });

            modelBuilder.Entity<TblEndUserRequisitionProducts>(entity =>
            {
                entity.HasKey(e => e.Eurpid);

                entity.ToTable("tbl_EndUserRequisitionProducts");

                entity.Property(e => e.Eurpid).HasColumnName("EURPID");

                entity.Property(e => e.BudgetEstimate).HasColumnType("money");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RequestTitle).HasMaxLength(200);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.TechnicalScore).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblEndUserRequisitionProducts)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionProducts_tbl_Clients");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblEndUserRequisitionProducts)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionProducts_tbl_Departments");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.TblEndUserRequisitionProducts)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionProducts_tbl_Position");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblEndUserRequisitionProducts)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionProducts_tbl_Projects");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TblEndUserRequisitionProducts)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionProducts_tbl_StaffBioData");
            });

            modelBuilder.Entity<TblEndUserRequisitionProductsDeliveryInfo>(entity =>
            {
                entity.HasKey(e => e.EurpdelInfoId)
                    .HasName("PK_EndUserRequisitionProductsDeliveryInfo");

                entity.ToTable("tbl_EndUserRequisitionProductsDeliveryInfo");

                entity.Property(e => e.EurpdelInfoId).HasColumnName("EURPDelInfoID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(200);

                entity.Property(e => e.Eurpid).HasColumnName("EURPID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.HasOne(d => d.Eurp)
                    .WithMany(p => p.TblEndUserRequisitionProductsDeliveryInfo)
                    .HasForeignKey(d => d.Eurpid)
                    .HasConstraintName("FK_tbl_EndUserRequisitionProductsDeliveryInfo_tbl_EndUserRequisitionProducts");
            });

            modelBuilder.Entity<TblEndUserRequisitionProductsDetails>(entity =>
            {
                entity.HasKey(e => e.EurpdetId);

                entity.ToTable("tbl_EndUserRequisitionProductsDetails");

                entity.Property(e => e.EurpdetId).HasColumnName("EURPDetID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EstimatedCost).HasColumnType("money");

                entity.Property(e => e.Eurpid).HasColumnName("EURPID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RefCodeStandards).HasMaxLength(100);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Eurp)
                    .WithMany(p => p.TblEndUserRequisitionProductsDetails)
                    .HasForeignKey(d => d.Eurpid)
                    .HasConstraintName("FK_tbl_EndUserRequisitionProductsDetails_tbl_EndUserRequisitionProducts");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblEndUserRequisitionProductsDetails)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("tbl_EndUserRequisitionProductsDetails_tbl_Units");
            });

            modelBuilder.Entity<TblEndUserRequisitionProductsMto>(entity =>
            {
                entity.HasKey(e => e.Eurpmtoid);

                entity.ToTable("tbl_EndUserRequisitionProductsMTO");

                entity.Property(e => e.Eurpmtoid).HasColumnName("EURPMTOID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Eurpid).HasColumnName("EURPID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtoformTitle)
                    .HasColumnName("MTOFormTitle")
                    .HasMaxLength(200);

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.HasOne(d => d.Eurp)
                    .WithMany(p => p.TblEndUserRequisitionProductsMto)
                    .HasForeignKey(d => d.Eurpid)
                    .HasConstraintName("FK_tbl_EndUserRequisitionProductsMTO_tbl_EndUserRequisitionProducts");

                entity.HasOne(d => d.Mtodiscipline)
                    .WithMany(p => p.TblEndUserRequisitionProductsMto)
                    .HasForeignKey(d => d.MtodisciplineId)
                    .HasConstraintName("tbl_EndUserRequisitionProductsMTO_tbl_MTODiscipline");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblEndUserRequisitionProductsMto)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .HasConstraintName("tbl_EndUserRequisitionProductsMTO_tbl_MTOSubDiscipline");
            });

            modelBuilder.Entity<TblEndUserRequisitionProductsOtherInfo>(entity =>
            {
                entity.HasKey(e => e.EurpotherInfoId);

                entity.ToTable("tbl_EndUserRequisitionProductsOtherInfo");

                entity.Property(e => e.EurpotherInfoId).HasColumnName("EURPOtherInfoID");

                entity.Property(e => e.AsservicesRq).HasColumnName("ASServicesRq");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DataSheet).HasMaxLength(100);

                entity.Property(e => e.Eurpid).HasColumnName("EURPID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Eurp)
                    .WithMany(p => p.TblEndUserRequisitionProductsOtherInfo)
                    .HasForeignKey(d => d.Eurpid)
                    .HasConstraintName("FK_tbl_EndUserRequisitionProductsOtherInfo_tbl_EndUserRequisitionProducts");
            });

            modelBuilder.Entity<TblEndUserRequisitionServiceAttachments>(entity =>
            {
                entity.HasKey(e => e.Eursaid);

                entity.ToTable("tbl_EndUserRequisitionServiceAttachments");

                entity.Property(e => e.Eursaid).HasColumnName("EURSAID");

                entity.Property(e => e.CommercialTemplate).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Eursid).HasColumnName("EURSID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceDrawingFiles).HasMaxLength(500);

                entity.Property(e => e.ReferenceDrawingNo).HasMaxLength(100);

                entity.Property(e => e.ReferenceDrawingTitle).HasMaxLength(100);

                entity.Property(e => e.TermsConditions).HasMaxLength(500);

                entity.Property(e => e.WorkSchedule).HasMaxLength(500);

                entity.HasOne(d => d.Eurs)
                    .WithMany(p => p.TblEndUserRequisitionServiceAttachments)
                    .HasForeignKey(d => d.Eursid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EndUserRequisitionServiceAttachments_tbl_EndUserRequisitionServices");
            });

            modelBuilder.Entity<TblEndUserRequisitionServiceDetails>(entity =>
            {
                entity.HasKey(e => e.Eursdid);

                entity.ToTable("tbl_EndUserRequisitionServiceDetails");

                entity.Property(e => e.Eursdid).HasColumnName("EURSDID");

                entity.Property(e => e.BudgetEstimate).HasColumnType("money");

                entity.Property(e => e.CommercialTemplate).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(200);

                entity.Property(e => e.DeliveryDueDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Eursid).HasColumnName("EURSID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RefCodesStandards).HasMaxLength(100);

                entity.Property(e => e.Renumeration).HasColumnType("money");

                entity.Property(e => e.ScopeOfWorks).HasMaxLength(1000);

                entity.Property(e => e.TechnicalEvalReq).HasMaxLength(100);

                entity.Property(e => e.TechnicalScore).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TermsConditions).HasMaxLength(100);

                entity.Property(e => e.ValidityPeriod).HasColumnType("datetime");

                entity.HasOne(d => d.Eurs)
                    .WithMany(p => p.TblEndUserRequisitionServiceDetails)
                    .HasForeignKey(d => d.Eursid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EndUserRequisitionServiceDetails_tbl_EndUserRequisitionServices");
            });

            modelBuilder.Entity<TblEndUserRequisitionServices>(entity =>
            {
                entity.HasKey(e => e.Eursid);

                entity.ToTable("tbl_EndUserRequisitionServices");

                entity.Property(e => e.Eursid).HasColumnName("EURSID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentTitle).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RequisitionNumber).HasMaxLength(20);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblEndUserRequisitionServices)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionServices_tbl_City");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblEndUserRequisitionServices)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionServices_tbl_Clients");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblEndUserRequisitionServices)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionServices_tbl_CompanyInfo");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblEndUserRequisitionServices)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionServices_tbl_Country");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblEndUserRequisitionServices)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionServices_tbl_Projects");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblEndUserRequisitionServices)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_EndUserRequisitionServices_tbl_State");
            });

            modelBuilder.Entity<TblEndUserRequisitionServicesMto>(entity =>
            {
                entity.HasKey(e => e.Eursmtoid);

                entity.ToTable("tbl_EndUserRequisitionServicesMTO");

                entity.Property(e => e.Eursmtoid).HasColumnName("EURSMTOID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Eursid).HasColumnName("EURSID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtoformId).HasColumnName("MTOFormID");

                entity.Property(e => e.MtoformTitle)
                    .HasColumnName("MTOFormTitle")
                    .HasMaxLength(200);

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.HasOne(d => d.Eurs)
                    .WithMany(p => p.TblEndUserRequisitionServicesMto)
                    .HasForeignKey(d => d.Eursid)
                    .HasConstraintName("FK_tbl_EndUserRequisitionServicesMTO_tbl_EndUserRequisitionServices");

                entity.HasOne(d => d.Mtodiscipline)
                    .WithMany(p => p.TblEndUserRequisitionServicesMto)
                    .HasForeignKey(d => d.MtodisciplineId)
                    .HasConstraintName("tbl_EndUserRequisitionServicesMTO_tbl_MTODiscipline");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblEndUserRequisitionServicesMto)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .HasConstraintName("tbl_EndUserRequisitionServicesMTO_tbl_MTOSubDiscipline");
            });

            modelBuilder.Entity<TblEquipment>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("tbl_Equipment");

                entity.Property(e => e.EquipmentId).HasColumnName("EquipmentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EquipmentCode).HasMaxLength(10);

                entity.Property(e => e.EquipmentName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblEventDetails>(entity =>
            {
                entity.HasKey(e => e.EventDetId);

                entity.ToTable("tbl_EventDetails");

                entity.Property(e => e.EventDetId).HasColumnName("EventDetID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Rfxnumber)
                    .HasColumnName("RFXNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Rfxowner).HasColumnName("RFXOwner");

                entity.Property(e => e.RfxstartDate)
                    .HasColumnName("RFXStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rfxstatus)
                    .HasColumnName("RFXStatus")
                    .HasMaxLength(100);

                entity.Property(e => e.SmartNumber).HasMaxLength(100);

                entity.Property(e => e.SubmissionDeadline).HasColumnType("datetime");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.TblEventDetails)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_tbl_EventDetails_tbl_Events");

                entity.HasOne(d => d.RfxownerNavigation)
                    .WithMany(p => p.TblEventDetails)
                    .HasForeignKey(d => d.Rfxowner)
                    .HasConstraintName("FK_tbl_EventDetails_tbl_StaffBioData");
            });

            modelBuilder.Entity<TblEventOtherInfo>(entity =>
            {
                entity.HasKey(e => e.EventOtherInfoId);

                entity.ToTable("tbl_EventOtherInfo");

                entity.Property(e => e.EventOtherInfoId).HasColumnName("EventOtherInfoID");

                entity.Property(e => e.Attachments).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.TblEventOtherInfo)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_tbl_EventOtherInfo_tbl_Events");
            });

            modelBuilder.Entity<TblEvents>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("tbl_Events");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EventDescription).HasMaxLength(20);

                entity.Property(e => e.EventNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseNumber).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblFinancialAudits>(entity =>
            {
                entity.HasKey(e => e.FinAudId);

                entity.ToTable("tbl_FinancialAudits");

                entity.Property(e => e.FinAudId).HasColumnName("FinAudID");

                entity.Property(e => e.AuditorAddress).HasMaxLength(500);

                entity.Property(e => e.AuditorName).HasMaxLength(200);

                entity.Property(e => e.ContactNumber).HasMaxLength(20);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TaxIdentificationNo).HasMaxLength(20);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblFinancialAudits)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_FinancialAudits_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblFinancialAuditsPerm>(entity =>
            {
                entity.HasKey(e => e.FinAudId);

                entity.ToTable("tbl_FinancialAuditsPerm");

                entity.Property(e => e.FinAudId).HasColumnName("FinAudID");

                entity.Property(e => e.AuditorAddress).HasMaxLength(500);

                entity.Property(e => e.AuditorName).HasMaxLength(200);

                entity.Property(e => e.ContactNumber).HasMaxLength(20);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TaxIdentificationNo).HasMaxLength(20);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblFinancialAuditsPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_FinancialAuditsPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblFinancialStatements>(entity =>
            {
                entity.HasKey(e => e.FinStatId);

                entity.ToTable("tbl_FinancialStatements");

                entity.Property(e => e.FinStatId).HasColumnName("FinStatID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblFinancialStatements)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_FinancialStatements_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblFinancialStatementsPerm>(entity =>
            {
                entity.HasKey(e => e.FinStatId);

                entity.ToTable("tbl_FinancialStatementsPerm");

                entity.Property(e => e.FinStatId).HasColumnName("FinStatID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblFinancialStatementsPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_FinancialStatementsPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblForeignCompany>(entity =>
            {
                entity.HasKey(e => e.ForComId);

                entity.ToTable("tbl_ForeignCompany");

                entity.Property(e => e.ForComId).HasColumnName("ForComID");

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.ProductSuppliedNavigation)
                    .WithMany(p => p.TblForeignCompany)
                    .HasForeignKey(d => d.ProductSupplied)
                    .HasConstraintName("FK_tbl_ForeignCompany_tbl_Products");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblForeignCompany)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ForeignCompany_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblForeignCompanyPerm>(entity =>
            {
                entity.HasKey(e => e.ForComId);

                entity.ToTable("tbl_ForeignCompanyPerm");

                entity.Property(e => e.ForComId).HasColumnName("ForComID");

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.ProductSuppliedNavigation)
                    .WithMany(p => p.TblForeignCompanyPerm)
                    .HasForeignKey(d => d.ProductSupplied)
                    .HasConstraintName("FK_tbl_ForeignCompanyPerm_tbl_Products");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblForeignCompanyPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ForeignCompanyPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblFormIdentification>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("tbl_FormIdentification");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VenPosId).HasColumnName("VenPosID");

                entity.Property(e => e.WorkPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.VenPos)
                    .WithMany(p => p.TblFormIdentification)
                    .HasForeignKey(d => d.VenPosId)
                    .HasConstraintName("tbl_FormIdentification_tbl_VendorPositions");
            });

            modelBuilder.Entity<TblFormIdentificationPerm>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("tbl_FormIdentificationPerm");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VenPosId).HasColumnName("VenPosID");

                entity.Property(e => e.WorkPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.VenPos)
                    .WithMany(p => p.TblFormIdentificationPerm)
                    .HasForeignKey(d => d.VenPosId)
                    .HasConstraintName("tbl_FormIdentificationPerm_tbl_VendorPositions");
            });

            modelBuilder.Entity<TblForms>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("tbl_Forms");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblHealthSafetyEnvironment>(entity =>
            {
                entity.HasKey(e => e.HseId);

                entity.ToTable("tbl_HealthSafetyEnvironment");

                entity.Property(e => e.HseId).HasColumnName("HSE_ID");

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.HseCompanyKpi).HasColumnName("HSE_CompanyKPI");

                entity.Property(e => e.HseManagerEmail)
                    .HasColumnName("HSE_ManagerEmail")
                    .HasMaxLength(100);

                entity.Property(e => e.HseManagerName)
                    .HasColumnName("HSE_ManagerName")
                    .HasMaxLength(200);

                entity.Property(e => e.HseYearN1results).HasColumnName("HSE_YearN1Results");

                entity.Property(e => e.Hsepolicy).HasColumnName("HSEPolicy");

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(100);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblHealthSafetyEnvironment)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_HealthSafetyEnvironment_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblHealthSafetyEnvironmentPerm>(entity =>
            {
                entity.HasKey(e => e.HseId);

                entity.ToTable("tbl_HealthSafetyEnvironmentPerm");

                entity.Property(e => e.HseId).HasColumnName("HSE_ID");

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.HseCompanyKpi).HasColumnName("HSE_CompanyKPI");

                entity.Property(e => e.HseManagerEmail)
                    .HasColumnName("HSE_ManagerEmail")
                    .HasMaxLength(100);

                entity.Property(e => e.HseManagerName)
                    .HasColumnName("HSE_ManagerName")
                    .HasMaxLength(200);

                entity.Property(e => e.HseYearN1results).HasColumnName("HSE_YearN1Results");

                entity.Property(e => e.Hsepolicy).HasColumnName("HSEPolicy");

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(100);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblHealthSafetyEnvironmentPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_HealthSafetyEnvironmentPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblHoliday>(entity =>
            {
                entity.HasKey(e => e.HolidayId);

                entity.ToTable("tbl_Holiday");

                entity.Property(e => e.HolidayId).HasColumnName("HolidayID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TblHoliday)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_tbl_Holiday_tbl_StaffBioData");
            });

            modelBuilder.Entity<TblHseCertification>(entity =>
            {
                entity.HasKey(e => e.HseCertId);

                entity.ToTable("tbl_HSE_Certification");

                entity.Property(e => e.HseCertId).HasColumnName("HSE_CertID");

                entity.Property(e => e.CertifyingOrganizationName).HasMaxLength(500);

                entity.Property(e => e.NameofCertificate).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.ValidityDate).HasColumnType("datetime");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblHseCertification)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_HSE_Certification_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblHseCertificationPerm>(entity =>
            {
                entity.HasKey(e => e.HseCertId);

                entity.ToTable("tbl_HSE_CertificationPerm");

                entity.Property(e => e.HseCertId).HasColumnName("HSE_CertID");

                entity.Property(e => e.CertifyingOrganizationName).HasMaxLength(500);

                entity.Property(e => e.NameofCertificate).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.ValidityDate).HasColumnType("datetime");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblHseCertificationPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_HSE_CertificationPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("tbl_Invoice");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.Attention).HasMaxLength(200);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyInfoId).HasColumnName("CompanyInfoID");

                entity.Property(e => e.Contact).HasMaxLength(200);

                entity.Property(e => e.ContractTitle).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.IssuedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PoId).HasColumnName("PO_ID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TaxIdnumber)
                    .HasColumnName("TaxIDNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Vatrate)
                    .HasColumnName("VATRate")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VatregNumber)
                    .HasColumnName("VATRegNumber")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblInvoice)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_Invoice_tbl_Clients");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.TblInvoice)
                    .HasForeignKey(d => d.CompanyInfoId)
                    .HasConstraintName("FK_tbl_Invoice_tbl_CompanyInfo");

                entity.HasOne(d => d.Po)
                    .WithMany(p => p.TblInvoice)
                    .HasForeignKey(d => d.PoId)
                    .HasConstraintName("FK_tbl_Invoice_tbl_PurchaseOrder");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblInvoice)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_Invoice_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblInvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.InvoiceDetId);

                entity.ToTable("tbl_InvoiceDetails");

                entity.Property(e => e.InvoiceDetId).HasColumnName("InvoiceDetID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AmountInWords).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.TblInvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_tbl_InvoiceDetails_tbl_Invoice");
            });

            modelBuilder.Entity<TblInvoiceOtherInfo>(entity =>
            {
                entity.HasKey(e => e.InvoiceOtherInfoId);

                entity.ToTable("tbl_InvoiceOtherInfo");

                entity.Property(e => e.InvoiceOtherInfoId).HasColumnName("InvoiceOtherInfoID");

                entity.Property(e => e.AccountDetails).HasMaxLength(100);

                entity.Property(e => e.AccountName).HasMaxLength(200);

                entity.Property(e => e.AccountNumber).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentBankId).HasColumnName("PaymentBankID");

                entity.Property(e => e.SortCode).HasMaxLength(20);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.TblInvoiceOtherInfo)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_tbl_InvoiceOtherInfo_tbl_Invoice");
            });

            modelBuilder.Entity<TblJobCompletionCertificate>(entity =>
            {
                entity.HasKey(e => e.Jccid);

                entity.ToTable("tbl_JobCompletionCertificate");

                entity.Property(e => e.Jccid).HasColumnName("JCCID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CertificateNumber).HasMaxLength(20);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecieptDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Telephone).HasMaxLength(20);

                entity.Property(e => e.WorkOrder).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblJobCompletionCertificate)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_JobCompletionCertificate_tbl_CompanyInfo");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblJobCompletionCertificate)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_JobCompletionCertificate_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblJustificationofAward>(entity =>
            {
                entity.HasKey(e => e.Joaid);

                entity.ToTable("tbl_JustificationofAward");

                entity.Property(e => e.Joaid).HasColumnName("JOAID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EndUser).HasMaxLength(100);

                entity.Property(e => e.EndUserDepartmentId).HasColumnName("EndUserDepartmentID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Rfqid).HasColumnName("RFQID");

                entity.Property(e => e.Rqnnumber)
                    .HasColumnName("RQNNumber")
                    .HasMaxLength(200);

                entity.Property(e => e.ScoreCommercialEval).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScoreTechnicalEval).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.VendorBidPrice).HasColumnType("money");

                entity.HasOne(d => d.EndUserDepartment)
                    .WithMany(p => p.TblJustificationofAward)
                    .HasForeignKey(d => d.EndUserDepartmentId)
                    .HasConstraintName("FK_tbl_JustificationofAward_tbl_Departments");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblJustificationofAward)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_JustificationofAward_tbl_Projects");

                entity.HasOne(d => d.Rfq)
                    .WithMany(p => p.TblJustificationofAward)
                    .HasForeignKey(d => d.Rfqid)
                    .HasConstraintName("FK_tbl_JustificationofAward_tbl_QuotationMaster");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblJustificationofAward)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_JustificationofAward_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("tbl_Log");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.Comments).HasMaxLength(1000);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<TblMainCustomers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("tbl_MainCustomers");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CustomerName).HasMaxLength(500);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Value).HasColumnType("money");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblMainCustomers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_MainCustomers_tbl_Country");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblMainCustomers)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_MainCustomers_tbl_Products");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblMainCustomers)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_tbl_MainCustomers_tbl_Services");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblMainCustomers)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MainCustomers_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblMainCustomersPerm>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("tbl_MainCustomersPerm");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CustomerName).HasMaxLength(500);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Value).HasColumnType("money");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblMainCustomersPerm)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_MainCustomersPerm_tbl_Country");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblMainCustomersPerm)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_MainCustomersPerm_tbl_Products");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblMainCustomersPerm)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_tbl_MainCustomersPerm_tbl_Services");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblMainCustomersPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MainCustomersPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblManufacturers>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId);

                entity.ToTable("tbl_Manufacturers");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ManufacturerName).HasMaxLength(100);

                entity.Property(e => e.StatusReason).HasMaxLength(200);
            });

            modelBuilder.Entity<TblMaterials>(entity =>
            {
                entity.HasKey(e => e.MaterialId);

                entity.ToTable("tbl_Materials");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MaterialName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblMtocivilForm>(entity =>
            {
                entity.HasKey(e => e.CivFormId);

                entity.ToTable("tbl_MTOCivilForm");

                entity.Property(e => e.CivFormId).HasColumnName("CivFormID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.ValidityPeriod).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblMtocivilForm)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_MTOCivilForm_tbl_Clients");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblMtocivilForm)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_MTOCivilForm_tbl_CompanyInfo");

                entity.HasOne(d => d.Mtodiscipline)
                    .WithMany(p => p.TblMtocivilForm)
                    .HasForeignKey(d => d.MtodisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOCivilForm_tbl_MTODiscipline");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblMtocivilForm)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOCivilForm_tbl_MTOSubDiscipline");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblMtocivilForm)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOCivilForm_tbl_Projects");
            });

            modelBuilder.Entity<TblMtocivilFormDetails>(entity =>
            {
                entity.HasKey(e => e.CivFormDetId);

                entity.ToTable("tbl_MTOCivilFormDetails");

                entity.Property(e => e.CivFormDetId).HasColumnName("CivFormDetID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CivFormId).HasColumnName("CivFormID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Subtotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.CivForm)
                    .WithMany(p => p.TblMtocivilFormDetails)
                    .HasForeignKey(d => d.CivFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOCivilFormDetails_tbl_MTOCivilForm");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblMtocivilFormDetails)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_MTOCivilFormDetails_tbl_Units");
            });

            modelBuilder.Entity<TblMtocivilFormDetailsTemp>(entity =>
            {
                entity.HasKey(e => e.CivFormDetId);

                entity.ToTable("tbl_MTOCivilFormDetailsTemp");

                entity.Property(e => e.CivFormDetId).HasColumnName("CivFormDetID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CivFormId).HasColumnName("CivFormID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Subtotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.CivForm)
                    .WithMany(p => p.TblMtocivilFormDetailsTemp)
                    .HasForeignKey(d => d.CivFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOCivilFormDetailsTemp_tbl_MTOCivilFormTemp");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblMtocivilFormDetailsTemp)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_MTOCivilFormDetailsTemp_tbl_Units");
            });

            modelBuilder.Entity<TblMtocivilFormTemp>(entity =>
            {
                entity.HasKey(e => e.CivFormId);

                entity.ToTable("tbl_MTOCivilFormTemp");

                entity.Property(e => e.CivFormId).HasColumnName("CivFormID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.ValidityPeriod).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblMtocivilFormTemp)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_MTOCivilFormTemp_tbl_Clients");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblMtocivilFormTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_MTOCivilFormTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Mtodiscipline)
                    .WithMany(p => p.TblMtocivilFormTemp)
                    .HasForeignKey(d => d.MtodisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOCivilFormTemp_tbl_MTODiscipline");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblMtocivilFormTemp)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOCivilFormTemp_tbl_MTOSubDiscipline");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblMtocivilFormTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOCivilFormTemp_tbl_Projects");
            });

            modelBuilder.Entity<TblMtodiscipline>(entity =>
            {
                entity.HasKey(e => e.DisciplineId);

                entity.ToTable("tbl_MTODiscipline");

                entity.Property(e => e.DisciplineId).HasColumnName("DisciplineID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblMtoelectricalForm>(entity =>
            {
                entity.HasKey(e => e.EleFormId);

                entity.ToTable("tbl_MTOElectricalForm");

                entity.Property(e => e.EleFormId).HasColumnName("EleFormID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.ValidityPeriod).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblMtoelectricalForm)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_MTOElectricalForm_tbl_Clients");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblMtoelectricalForm)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_MTOElectricalForm_tbl_CompanyInfo");

                entity.HasOne(d => d.Mtodiscipline)
                    .WithMany(p => p.TblMtoelectricalForm)
                    .HasForeignKey(d => d.MtodisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOElectricalForm_tbl_MTODiscipline");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblMtoelectricalForm)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOElectricalForm_tbl_MTOSubDiscipline");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblMtoelectricalForm)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOElectricalForm_tbl_Projects");
            });

            modelBuilder.Entity<TblMtoelectricalFormDetails>(entity =>
            {
                entity.HasKey(e => e.EleFormDetId);

                entity.ToTable("tbl_MTOElectricalFormDetails");

                entity.Property(e => e.EleFormDetId).HasColumnName("EleFormDetID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EleFormId).HasColumnName("EleFormID");

                entity.Property(e => e.GlandSize).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemDescription).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.Voltage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblMtoelectricalFormDetails)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetails_tbl_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblMtoelectricalFormDetails)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetails_tbl_Country");

                entity.HasOne(d => d.EleForm)
                    .WithMany(p => p.TblMtoelectricalFormDetails)
                    .HasForeignKey(d => d.EleFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetails_tbl_MTOElectricalForm");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblMtoelectricalFormDetails)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetails_tbl_State");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblMtoelectricalFormDetails)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetails_tbl_Units");
            });

            modelBuilder.Entity<TblMtoelectricalFormDetailsTemp>(entity =>
            {
                entity.HasKey(e => e.EleFormDetId);

                entity.ToTable("tbl_MTOElectricalFormDetailsTemp");

                entity.Property(e => e.EleFormDetId).HasColumnName("EleFormDetID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EleFormId).HasColumnName("EleFormID");

                entity.Property(e => e.GlandSize).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemDescription).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.Voltage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblMtoelectricalFormDetailsTemp)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetailsTemp_tbl_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblMtoelectricalFormDetailsTemp)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetailsTemp_tbl_Country");

                entity.HasOne(d => d.EleForm)
                    .WithMany(p => p.TblMtoelectricalFormDetailsTemp)
                    .HasForeignKey(d => d.EleFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetailsTemp_tbl_MTOElectricalFormTemp");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblMtoelectricalFormDetailsTemp)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetailsTemp_tbl_State");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblMtoelectricalFormDetailsTemp)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormDetailsTemp_tbl_Units");
            });

            modelBuilder.Entity<TblMtoelectricalFormTemp>(entity =>
            {
                entity.HasKey(e => e.EleFormId);

                entity.ToTable("tbl_MTOElectricalFormTemp");

                entity.Property(e => e.EleFormId).HasColumnName("EleFormID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.ValidityPeriod).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblMtoelectricalFormTemp)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormTemp_tbl_Clients");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblMtoelectricalFormTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_MTOElectricalFormTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Mtodiscipline)
                    .WithMany(p => p.TblMtoelectricalFormTemp)
                    .HasForeignKey(d => d.MtodisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOElectricalFormTemp_tbl_MTODiscipline");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblMtoelectricalFormTemp)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOElectricalFormTemp_tbl_MTOSubDiscipline");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblMtoelectricalFormTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOElectricalFormTemp_tbl_Projects");
            });

            modelBuilder.Entity<TblMtoinstrumentForm>(entity =>
            {
                entity.HasKey(e => e.InsFormId);

                entity.ToTable("tbl_MTOInstrumentForm");

                entity.Property(e => e.InsFormId).HasColumnName("InsFormID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.ValidityPeriod).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblMtoinstrumentForm)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_MTOInstrumentForm_tbl_Clients");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblMtoinstrumentForm)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_MTOInstrumentForm_tbl_CompanyInfo");

                entity.HasOne(d => d.Mtodiscipline)
                    .WithMany(p => p.TblMtoinstrumentForm)
                    .HasForeignKey(d => d.MtodisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOInstrumentForm_tbl_MTODiscipline");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblMtoinstrumentForm)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOInstrumentForm_tbl_MTOSubDiscipline");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblMtoinstrumentForm)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOInstrumentForm_tbl_Projects");
            });

            modelBuilder.Entity<TblMtoinstrumentFormDetails>(entity =>
            {
                entity.HasKey(e => e.InsFormDetId);

                entity.ToTable("tbl_MTOInstrumentFormDetails");

                entity.Property(e => e.InsFormDetId).HasColumnName("insFormDetID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InsFormId).HasColumnName("InsFormID");

                entity.Property(e => e.ItemDescription).HasMaxLength(1000);

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.MarkedUpQuantity).HasMaxLength(100);

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.ModelNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.InsForm)
                    .WithMany(p => p.TblMtoinstrumentFormDetails)
                    .HasForeignKey(d => d.InsFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormDetails_tbl_MTOInstrumentForm");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.TblMtoinstrumentFormDetails)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormDetails_tbl_Manufacturers");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.TblMtoinstrumentFormDetails)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormDetails_tbl_Materials");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblMtoinstrumentFormDetails)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormDetails_tbl_Units");
            });

            modelBuilder.Entity<TblMtoinstrumentFormDetailsTemp>(entity =>
            {
                entity.HasKey(e => e.InsFormDetId);

                entity.ToTable("tbl_MTOInstrumentFormDetailsTemp");

                entity.Property(e => e.InsFormDetId).HasColumnName("insFormDetID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InsFormId).HasColumnName("InsFormID");

                entity.Property(e => e.ItemDescription).HasMaxLength(1000);

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.MarkedUpQuantity).HasMaxLength(100);

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.ModelNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.InsForm)
                    .WithMany(p => p.TblMtoinstrumentFormDetailsTemp)
                    .HasForeignKey(d => d.InsFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormDetailsTemp_tbl_MTOInstrumentFormTemp");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.TblMtoinstrumentFormDetailsTemp)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormDetailsTemp_tbl_Manufacturers");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.TblMtoinstrumentFormDetailsTemp)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormDetailsTemp_tbl_Materials");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.TblMtoinstrumentFormDetailsTemp)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormDetailsTemp_tbl_Units");
            });

            modelBuilder.Entity<TblMtoinstrumentFormTemp>(entity =>
            {
                entity.HasKey(e => e.InsFormId);

                entity.ToTable("tbl_MTOInstrumentFormTemp");

                entity.Property(e => e.InsFormId).HasColumnName("InsFormID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.ValidityPeriod).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblMtoinstrumentFormTemp)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormTemp_tbl_Clients");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblMtoinstrumentFormTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblMtoinstrumentFormTemp)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormTemp_tbl_MTOSubDiscipline");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblMtoinstrumentFormTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOInstrumentFormTemp_tbl_Projects");
            });

            modelBuilder.Entity<TblMtopipingForm>(entity =>
            {
                entity.HasKey(e => e.PipFormId)
                    .HasName("PK_tbl_MTOPipingForms");

                entity.ToTable("tbl_MTOPipingForm");

                entity.Property(e => e.PipFormId).HasColumnName("PipFormID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.ValidityPeriod).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblMtopipingForm)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_MTOPipingForms_tbl_Clients");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblMtopipingForm)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_MTOPipingForms_tbl_CompanyInfo");

                entity.HasOne(d => d.Mtodiscipline)
                    .WithMany(p => p.TblMtopipingForm)
                    .HasForeignKey(d => d.MtodisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOPipingForms_tbl_MTODiscipline");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblMtopipingForm)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOPipingForms_tbl_MTOSubDiscipline");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblMtopipingForm)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOPipingForms_tbl_Projects");
            });

            modelBuilder.Entity<TblMtopipingFormDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_MTOPipingFormDetails");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Item).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PipFormDetId).HasColumnName("PipFormDetID");

                entity.Property(e => e.PipFormId).HasColumnName("PipFormID");

                entity.Property(e => e.Schedule).HasMaxLength(100);

                entity.Property(e => e.Spare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.PipForm)
                    .WithMany()
                    .HasForeignKey(d => d.PipFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOPipingFormDetails_tbl_MTOPipingForm");

                entity.HasOne(d => d.Unit)
                    .WithMany()
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_MTOPipingFormDetails_tbl_Units");
            });

            modelBuilder.Entity<TblMtopipingFormDetailsTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_MTOPipingFormDetailsTemp");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Item).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PipFormDetId).HasColumnName("PipFormDetID");

                entity.Property(e => e.PipFormId).HasColumnName("PipFormID");

                entity.Property(e => e.Schedule).HasMaxLength(100);

                entity.Property(e => e.Spare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.PipForm)
                    .WithMany()
                    .HasForeignKey(d => d.PipFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOPipingFormDetailsTemp_tbl_MTOPipingFormTemp");

                entity.HasOne(d => d.Unit)
                    .WithMany()
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_tbl_MTOPipingFormDetailsTemp_tbl_Units");
            });

            modelBuilder.Entity<TblMtopipingFormTemp>(entity =>
            {
                entity.HasKey(e => e.PipFormId)
                    .HasName("PK_tbl_MTOPipingFormsTemp");

                entity.ToTable("tbl_MTOPipingFormTemp");

                entity.Property(e => e.PipFormId).HasColumnName("PipFormID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtodisciplineId).HasColumnName("MTODisciplineID");

                entity.Property(e => e.MtosubDisciplineId).HasColumnName("MTOSubDisciplineID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.ValidityPeriod).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblMtopipingFormTemp)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_MTOPipingFormsTemp_tbl_Clients");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblMtopipingFormTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_MTOPipingFormsTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Mtodiscipline)
                    .WithMany(p => p.TblMtopipingFormTemp)
                    .HasForeignKey(d => d.MtodisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOPipingFormsTemp_tbl_MTODiscipline");

                entity.HasOne(d => d.MtosubDiscipline)
                    .WithMany(p => p.TblMtopipingFormTemp)
                    .HasForeignKey(d => d.MtosubDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOPipingFormsTemp_tbl_MTOSubDiscipline");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblMtopipingFormTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOPipingFormsTemp_tbl_Projects");
            });

            modelBuilder.Entity<TblMtosubDiscipline>(entity =>
            {
                entity.HasKey(e => e.SubDisciplineId);

                entity.ToTable("tbl_MTOSubDiscipline");

                entity.Property(e => e.SubDisciplineId).HasColumnName("SubDisciplineID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DisciplineId).HasColumnName("DisciplineID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Discipline)
                    .WithMany(p => p.TblMtosubDiscipline)
                    .HasForeignKey(d => d.DisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MTOSubDiscipline_tbl_MTODiscipline");
            });

            modelBuilder.Entity<TblNotificationGroup>(entity =>
            {
                entity.HasKey(e => e.NoGrId);

                entity.ToTable("tbl_NotificationGroup");

                entity.Property(e => e.NoGrId).HasColumnName("NoGrID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.WfdefId).HasColumnName("WFDefID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblNotificationGroup)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_tbl_NotificationGroup_tbl_Departments");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.TblNotificationGroup)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_tbl_NotificationGroup_tbl_Position");

                entity.HasOne(d => d.Wfdef)
                    .WithMany(p => p.TblNotificationGroup)
                    .HasForeignKey(d => d.WfdefId)
                    .HasConstraintName("FK_tbl_NotificationGroup_tbl_WorkflowProcessDef");
            });

            modelBuilder.Entity<TblNumberOfEmployees>(entity =>
            {
                entity.HasKey(e => e.NoOfEmpId);

                entity.ToTable("tbl_NumberOfEmployees");

                entity.Property(e => e.NoOfEmpId).HasColumnName("NoOfEmpID");

                entity.Property(e => e.StaffStrCompId).HasColumnName("StaffStrCompID");

                entity.Property(e => e.VenDepId).HasColumnName("VenDepID");

                entity.HasOne(d => d.StaffStrComp)
                    .WithMany(p => p.TblNumberOfEmployees)
                    .HasForeignKey(d => d.StaffStrCompId)
                    .HasConstraintName("FK_tbl_NumberofEmployees_tbl_StaffStrengthComp");

                entity.HasOne(d => d.VenDep)
                    .WithMany(p => p.TblNumberOfEmployees)
                    .HasForeignKey(d => d.VenDepId)
                    .HasConstraintName("tbl_FormIdentification_tbl_VendorDepartments");
            });

            modelBuilder.Entity<TblNumberOfEmployeesPerm>(entity =>
            {
                entity.HasKey(e => e.NoOfEmpId);

                entity.ToTable("tbl_NumberOfEmployeesPerm");

                entity.Property(e => e.NoOfEmpId).HasColumnName("NoOfEmpID");

                entity.Property(e => e.StaffStrCompId).HasColumnName("StaffStrCompID");

                entity.Property(e => e.VenDepId).HasColumnName("VenDepID");

                entity.HasOne(d => d.StaffStrComp)
                    .WithMany(p => p.TblNumberOfEmployeesPerm)
                    .HasForeignKey(d => d.StaffStrCompId)
                    .HasConstraintName("FK_tbl_NumberOfEmployeesPerm_tbl_StaffStrengthCompPerm");

                entity.HasOne(d => d.VenDep)
                    .WithMany(p => p.TblNumberOfEmployeesPerm)
                    .HasForeignKey(d => d.VenDepId)
                    .HasConstraintName("tbl_FormIdentificationPerm_tbl_VendorDepartments");
            });

            modelBuilder.Entity<TblOfficeServiceCl>(entity =>
            {
                entity.HasKey(e => e.OfficeServClId);

                entity.ToTable("tbl_OfficeServiceCL");

                entity.Property(e => e.OfficeServClId).HasColumnName("OfficeServCL_ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Location).HasMaxLength(500);

                entity.Property(e => e.SpServices)
                    .HasColumnName("SP_Services")
                    .HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblOfficeServiceCl)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_OfficeServiceCL_tbl_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblOfficeServiceCl)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_OfficeServiceCL_tbl_Country");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblOfficeServiceCl)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_OfficeServiceCL_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblOfficeServiceClperm>(entity =>
            {
                entity.HasKey(e => e.OfficeServClId);

                entity.ToTable("tbl_OfficeServiceCLPerm");

                entity.Property(e => e.OfficeServClId).HasColumnName("OfficeServCL_ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Location).HasMaxLength(500);

                entity.Property(e => e.SpServices)
                    .HasColumnName("SP_Services")
                    .HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblOfficeServiceClperm)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_OfficeServiceCLPerm_tbl_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblOfficeServiceClperm)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_OfficeServiceCLPerm_tbl_Country");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblOfficeServiceClperm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_OfficeServiceCLPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblPaymentBank>(entity =>
            {
                entity.HasKey(e => e.PymntBankId);

                entity.ToTable("tbl_PaymentBank");

                entity.Property(e => e.PymntBankId).HasColumnName("PymntBankID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentBankCode).HasMaxLength(10);

                entity.Property(e => e.PaymentBankName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblPaymentRequestDetails>(entity =>
            {
                entity.HasKey(e => e.PayReqDetId);

                entity.ToTable("tbl_PaymentRequestDetails");

                entity.Property(e => e.PayReqDetId).HasColumnName("PayReqDetID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AmountInWords)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.GlaccountCode)
                    .IsRequired()
                    .HasColumnName("GLAccountCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PayReqMasterId).HasColumnName("PayReqMasterID");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.HasOne(d => d.PayReqMaster)
                    .WithMany(p => p.TblPaymentRequestDetails)
                    .HasForeignKey(d => d.PayReqMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaymentRequestDetails_tbl_PaymentRequestMaster");
            });

            modelBuilder.Entity<TblPaymentRequestMaster>(entity =>
            {
                entity.HasKey(e => e.PayReqMasterId);

                entity.ToTable("tbl_PaymentRequestMaster");

                entity.Property(e => e.PayReqMasterId).HasColumnName("PayReqMasterID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PayReqDate).HasColumnType("datetime");

                entity.Property(e => e.PayReqNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Payee)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PaymentBankId).HasColumnName("PaymentBankID");

                entity.Property(e => e.PoId).HasColumnName("PO_ID");

                entity.HasOne(d => d.DepartmentProjectNavigation)
                    .WithMany(p => p.TblPaymentRequestMaster)
                    .HasForeignKey(d => d.DepartmentProject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaymentRequestMaster_tbl_Departments");

                entity.HasOne(d => d.PaymentBank)
                    .WithMany(p => p.TblPaymentRequestMaster)
                    .HasForeignKey(d => d.PaymentBankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaymentRequestMaster_tbl_PaymentBank");

                entity.HasOne(d => d.Po)
                    .WithMany(p => p.TblPaymentRequestMaster)
                    .HasForeignKey(d => d.PoId)
                    .HasConstraintName("FK_tbl_PaymentRequestMaster_tbl_PurchaseOrder");
            });

            modelBuilder.Entity<TblPosition>(entity =>
            {
                entity.HasKey(e => e.PositionId);

                entity.ToTable("tbl_Position");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.PositionCode).HasMaxLength(10);

                entity.Property(e => e.PositionEmailAddress).HasMaxLength(100);

                entity.Property(e => e.PositionTitle).HasMaxLength(200);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblPosition)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_tbl_Position_tbl_Departments");
            });

            modelBuilder.Entity<TblProductCategory>(entity =>
            {
                entity.HasKey(e => e.ProductCatId);

                entity.ToTable("tbl_ProductCategory");

                entity.Property(e => e.ProductCatId).HasColumnName("ProductCatID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DprcatId).HasColumnName("DPRCatID");

                entity.Property(e => e.ProductCatCode).HasMaxLength(10);

                entity.Property(e => e.ProductCatName).HasMaxLength(100);

                entity.HasOne(d => d.Dprcat)
                    .WithMany(p => p.TblProductCategory)
                    .HasForeignKey(d => d.DprcatId)
                    .HasConstraintName("FK_tbl_ProductCategory_tbl_DPRCategory");
            });

            modelBuilder.Entity<TblProductServiceCategory>(entity =>
            {
                entity.HasKey(e => e.ProdServId);

                entity.ToTable("tbl_ProductServiceCategory");

                entity.Property(e => e.ProdServId).HasColumnName("ProdServID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<TblProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_Products");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCatId).HasColumnName("ProductCatID");

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.HasOne(d => d.ProductCat)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.ProductCatId)
                    .HasConstraintName("FK_tbl_Products_tbl_ProductCategory");
            });

            modelBuilder.Entity<TblProjects>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("tbl_Projects");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblPurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.PoId);

                entity.ToTable("tbl_PurchaseOrder");

                entity.Property(e => e.PoId).HasColumnName("PO_ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Poamount)
                    .HasColumnName("POAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Potype).HasColumnName("POType");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.QuoMasterId).HasColumnName("QuoMasterID");

                entity.Property(e => e.QuoteRef).HasMaxLength(100);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblPurchaseOrder)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_PurchaseOrder_tbl_CompanyInfo");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblPurchaseOrder)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_PurchaseOrder_tbl_Projects");

                entity.HasOne(d => d.QuoMaster)
                    .WithMany(p => p.TblPurchaseOrder)
                    .HasForeignKey(d => d.QuoMasterId)
                    .HasConstraintName("FK_tbl_PurchaseOrder_tbl_QuotationMaster");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblPurchaseOrder)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PurchaseOrder_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblPurchaseOrderDetails>(entity =>
            {
                entity.HasKey(e => e.PodetId);

                entity.ToTable("tbl_PurchaseOrderDetails");

                entity.Property(e => e.PodetId).HasColumnName("PODet_ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(500);

                entity.Property(e => e.DeliveryTerms).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PoId).HasColumnName("PO_ID");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.Property(e => e.UnitCost).HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblPurchaseOrderDetails)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_tbl_PurchaseOrderDetails_tbl_Currency");

                entity.HasOne(d => d.Po)
                    .WithMany(p => p.TblPurchaseOrderDetails)
                    .HasForeignKey(d => d.PoId)
                    .HasConstraintName("FK_tbl_PurchaseOrderDetails_tbl_PurchaseOrder");
            });

            modelBuilder.Entity<TblPurchaseOrderMilestones>(entity =>
            {
                entity.HasKey(e => e.MilestoneId);

                entity.ToTable("tbl_PurchaseOrderMilestones");

                entity.Property(e => e.MilestoneId).HasColumnName("MilestoneID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedDate).HasColumnType("datetime");

                entity.Property(e => e.MilestoneAmount).HasColumnType("money");

                entity.Property(e => e.MilestoneDetails).HasMaxLength(500);

                entity.Property(e => e.MilestoneWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PoId).HasColumnName("PO_ID");

                entity.Property(e => e.Vendor).HasMaxLength(200);

                entity.HasOne(d => d.Po)
                    .WithMany(p => p.TblPurchaseOrderMilestones)
                    .HasForeignKey(d => d.PoId)
                    .HasConstraintName("FK_tbl_PurchaseOrderMilestones_tbl_PurchaseOrder");
            });

            modelBuilder.Entity<TblQualityCertification>(entity =>
            {
                entity.HasKey(e => e.QualCertId);

                entity.ToTable("tbl_QualityCertification");

                entity.Property(e => e.QualCertId).HasColumnName("QualCertID");

                entity.Property(e => e.CertifyingOrganizationName).HasMaxLength(500);

                entity.Property(e => e.NameofCertificate).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.ValidityDate).HasColumnType("datetime");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblQualityCertification)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_QualityCertification_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblQualityCertificationPerm>(entity =>
            {
                entity.HasKey(e => e.QualCertId);

                entity.ToTable("tbl_QualityCertificationPerm");

                entity.Property(e => e.QualCertId).HasColumnName("QualCertID");

                entity.Property(e => e.CertifyingOrganizationName).HasMaxLength(500);

                entity.Property(e => e.NameofCertificate).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.ValidityDate).HasColumnType("datetime");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblQualityCertificationPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_QualityCertificationPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblQualityManagement>(entity =>
            {
                entity.HasKey(e => e.QualMgtId);

                entity.ToTable("tbl_QualityManagement");

                entity.Property(e => e.QualMgtId).HasColumnName("QualMgtID");

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.QualManagerEmail).HasMaxLength(100);

                entity.Property(e => e.QualManagerName).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(100);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblQualityManagement)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_QualityManagement_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblQualityManagementPerm>(entity =>
            {
                entity.HasKey(e => e.QualMgtId);

                entity.ToTable("tbl_QualityManagementPerm");

                entity.Property(e => e.QualMgtId).HasColumnName("QualMgtID");

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.QualManagerEmail).HasMaxLength(100);

                entity.Property(e => e.QualManagerName).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(100);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblQualityManagementPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_QualityManagementPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblQuotationApproval>(entity =>
            {
                entity.HasKey(e => e.QuoAppId);

                entity.ToTable("tbl_QuotationApproval");

                entity.Property(e => e.QuoAppId).HasColumnName("QuoAppID");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovalSignature).HasMaxLength(100);

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.QuoMasterId).HasColumnName("QuoMasterID");

                entity.HasOne(d => d.QuoMaster)
                    .WithMany(p => p.TblQuotationApproval)
                    .HasForeignKey(d => d.QuoMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_QuotationApproval_tbl_QuotationMaster");
            });

            modelBuilder.Entity<TblQuotationDeliveryInfo>(entity =>
            {
                entity.HasKey(e => e.DelInfoId)
                    .HasName("PK_tbl_DeliveryInfo");

                entity.ToTable("tbl_QuotationDeliveryInfo");

                entity.Property(e => e.DelInfoId).HasColumnName("DelInfoID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoMasterId).HasColumnName("QuoMasterID");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.SpecialInstructions).IsRequired();

                entity.HasOne(d => d.QuoMaster)
                    .WithMany(p => p.TblQuotationDeliveryInfo)
                    .HasForeignKey(d => d.QuoMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_QuotationDeliveryInfo_tbl_QuotationMaster");
            });

            modelBuilder.Entity<TblQuotationDetails>(entity =>
            {
                entity.HasKey(e => e.QuoDetId)
                    .HasName("PK_tbl_QuotationDetail");

                entity.ToTable("tbl_QuotationDetails");

                entity.Property(e => e.QuoDetId).HasColumnName("QuoDetID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EstimatedCost).HasColumnType("money");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoMasterId).HasColumnName("QuoMasterID");

                entity.Property(e => e.QuoteRef).HasMaxLength(100);

                entity.HasOne(d => d.QuoMaster)
                    .WithMany(p => p.TblQuotationDetails)
                    .HasForeignKey(d => d.QuoMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_QuotationDetails_tbl_QuotationMaster");
            });

            modelBuilder.Entity<TblQuotationMaster>(entity =>
            {
                entity.HasKey(e => e.QuoMasterId);

                entity.ToTable("tbl_QuotationMaster");

                entity.Property(e => e.QuoMasterId).HasColumnName("QuoMasterID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryReminderDate).HasColumnType("datetime");

                entity.Property(e => e.ExtensionDate).HasColumnType("datetime");

                entity.Property(e => e.ExtensionReminder).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.QuotationDate).HasColumnType("datetime");

                entity.Property(e => e.RequestTitle).HasMaxLength(200);

                entity.Property(e => e.Rfqnumber)
                    .HasColumnName("RFQNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Rfqtype).HasColumnName("RFQType");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TenderAttId).HasColumnName("TenderAttID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblQuotationMaster)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_tbl_QuotationMaster_tbl_Clients");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.TblQuotationMaster)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_tbl_QuotationMaster_tbl_Events");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblQuotationMaster)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_QuotationMaster_tbl_Projects");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblQuotationMaster)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_QuotationMaster_tbl_SupplierIdentification");

                entity.HasOne(d => d.TenderAtt)
                    .WithMany(p => p.TblQuotationMaster)
                    .HasForeignKey(d => d.TenderAttId)
                    .HasConstraintName("FK_tbl_QuotationMaster_tbl_TenderAttachements");
            });

            modelBuilder.Entity<TblQuotationOtherInfo>(entity =>
            {
                entity.HasKey(e => e.OtherInfoId);

                entity.ToTable("tbl_QuotationOtherInfo");

                entity.Property(e => e.OtherInfoId).HasColumnName("OtherInfoID");

                entity.Property(e => e.AsservicesRq)
                    .IsRequired()
                    .HasColumnName("ASServicesRq");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoMasterId).HasColumnName("QuoMasterID");

                entity.HasOne(d => d.QuoMaster)
                    .WithMany(p => p.TblQuotationOtherInfo)
                    .HasForeignKey(d => d.QuoMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_QuotationOtherInfo_tbl_QuotationMaster");
            });

            modelBuilder.Entity<TblQuotationOtherInfoAttachments>(entity =>
            {
                entity.HasKey(e => e.Qoiaid);

                entity.ToTable("tbl_QuotationOtherInfoAttachments");

                entity.Property(e => e.Qoiaid).HasColumnName("QOIAID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DataSheet).HasMaxLength(100);

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mtocertificate)
                    .HasColumnName("MTOCertificate")
                    .HasMaxLength(100);

                entity.Property(e => e.OtherInfoId).HasColumnName("OtherInfoID");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.TblQuotationOtherInfoAttachments)
                    .HasForeignKey(d => d.DocTypeId)
                    .HasConstraintName("FK_tbl_QuotationOtherInfoAttachments_tbl_DocumentType");

                entity.HasOne(d => d.OtherInfo)
                    .WithMany(p => p.TblQuotationOtherInfoAttachments)
                    .HasForeignKey(d => d.OtherInfoId)
                    .HasConstraintName("FK_tbl_QuotationOtherInfoAttachments_tbl_QuotationOtherInfo");
            });

            modelBuilder.Entity<TblServices>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("tbl_Services");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ServCatId).HasColumnName("ServCatID");

                entity.Property(e => e.ServiceCode).HasMaxLength(10);

                entity.Property(e => e.ServiceName).HasMaxLength(100);

                entity.HasOne(d => d.ServCat)
                    .WithMany(p => p.TblServices)
                    .HasForeignKey(d => d.ServCatId)
                    .HasConstraintName("FK_tbl_Services_tbl_ServicesCategory");
            });

            modelBuilder.Entity<TblServicesCategory>(entity =>
            {
                entity.HasKey(e => e.ServCatId);

                entity.ToTable("tbl_ServicesCategory");

                entity.Property(e => e.ServCatId).HasColumnName("ServCatID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DprcatId).HasColumnName("DPRCatID");

                entity.Property(e => e.ServCatCode).HasMaxLength(10);

                entity.Property(e => e.ServCatName).HasMaxLength(100);

                entity.HasOne(d => d.Dprcat)
                    .WithMany(p => p.TblServicesCategory)
                    .HasForeignKey(d => d.DprcatId)
                    .HasConstraintName("FK_tbl_ServicesCategory_tbl_DPRCategory");
            });

            modelBuilder.Entity<TblSingleTenderJustification>(entity =>
            {
                entity.HasKey(e => e.Stjid);

                entity.ToTable("tbl_SingleTenderJustification");

                entity.Property(e => e.Stjid).HasColumnName("STJID");

                entity.Property(e => e.AdditionalInfo).HasMaxLength(100);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProposedContractValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProposedContractor).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TelephoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSingleTenderJustification)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SingleTenderJustification_tbl_Projects");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSingleTenderJustification)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_SingleTenderJustification_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblSpDirectServiceScope>(entity =>
            {
                entity.HasKey(e => e.SpDssId);

                entity.ToTable("tbl_SP_DirectServiceScope");

                entity.Property(e => e.SpDssId).HasColumnName("SP_DSS_ID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblSpDirectServiceScope)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_tbl_SP_DirectServiceScope_tbl_Services");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSpDirectServiceScope)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_SP_DirectServiceScope_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblSpDirectServiceScopePerm>(entity =>
            {
                entity.HasKey(e => e.SpDssId);

                entity.ToTable("tbl_SP_DirectServiceScopePerm");

                entity.Property(e => e.SpDssId).HasColumnName("SP_DSS_ID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblSpDirectServiceScopePerm)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_tbl_SP_DirectServiceScopePerm_tbl_Services");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSpDirectServiceScopePerm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_SP_DirectServiceScopePerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblSrconstructionTechnicalQueries>(entity =>
            {
                entity.HasKey(e => e.Ctqid);

                entity.ToTable("tbl_SRConstructionTechnicalQueries");

                entity.Property(e => e.Ctqid).HasColumnName("CTQID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ctqdescription).HasColumnName("CTQDescription");

                entity.Property(e => e.Ctqnumber)
                    .IsRequired()
                    .HasColumnName("CTQNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Ctqtitle)
                    .IsRequired()
                    .HasColumnName("CTQTitle")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.QueryDate).HasColumnType("datetime");

                entity.Property(e => e.ReplyRequiredBy).HasColumnType("datetime");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.AttentionNavigation)
                    .WithMany(p => p.TblSrconstructionTechnicalQueriesAttentionNavigation)
                    .HasForeignKey(d => d.Attention)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueries_tbl_StaffBioData1");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblSrconstructionTechnicalQueries)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueries_tbl_City");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrconstructionTechnicalQueries)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueries_tbl_CompanyInfo");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblSrconstructionTechnicalQueries)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueries_tbl_Country");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrconstructionTechnicalQueries)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueries_tbl_Projects");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TblSrconstructionTechnicalQueriesStaff)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueries_tbl_StaffBioData");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblSrconstructionTechnicalQueries)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueries_tbl_State");
            });

            modelBuilder.Entity<TblSrconstructionTechnicalQueriesTemp>(entity =>
            {
                entity.HasKey(e => e.Ctqid);

                entity.ToTable("tbl_SRConstructionTechnicalQueriesTemp");

                entity.Property(e => e.Ctqid).HasColumnName("CTQID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ctqdescription).HasColumnName("CTQDescription");

                entity.Property(e => e.Ctqnumber)
                    .IsRequired()
                    .HasColumnName("CTQNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Ctqtitle)
                    .IsRequired()
                    .HasColumnName("CTQTitle")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.QueryDate).HasColumnType("datetime");

                entity.Property(e => e.ReplyRequiredBy).HasColumnType("datetime");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.AttentionNavigation)
                    .WithMany(p => p.TblSrconstructionTechnicalQueriesTempAttentionNavigation)
                    .HasForeignKey(d => d.Attention)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueriesTemp_tbl_StaffBioData1");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblSrconstructionTechnicalQueriesTemp)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueriesTemp_tbl_City");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrconstructionTechnicalQueriesTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueriesTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblSrconstructionTechnicalQueriesTemp)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueriesTemp_tbl_Country");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrconstructionTechnicalQueriesTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueriesTemp_tbl_Projects");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TblSrconstructionTechnicalQueriesTempStaff)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueriesTemp_tbl_StaffBioData");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblSrconstructionTechnicalQueriesTemp)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueriesTemp_tbl_State");
            });

            modelBuilder.Entity<TblSrconstructionTechnicalQueryAttachments>(entity =>
            {
                entity.HasKey(e => e.QueryAttId);

                entity.ToTable("tbl_SRConstructionTechnicalQueryAttachments");

                entity.Property(e => e.QueryAttId).HasColumnName("QueryAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ctqid).HasColumnName("CTQID");

                entity.Property(e => e.DrawingFile).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNumber).HasMaxLength(100);

                entity.HasOne(d => d.Ctq)
                    .WithMany(p => p.TblSrconstructionTechnicalQueryAttachments)
                    .HasForeignKey(d => d.Ctqid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueryAttachments_tbl_SRConstructionTechnicalQueries");
            });

            modelBuilder.Entity<TblSrconstructionTechnicalQueryAttachmentsTemp>(entity =>
            {
                entity.HasKey(e => e.QueryAttId);

                entity.ToTable("tbl_SRConstructionTechnicalQueryAttachmentsTemp");

                entity.Property(e => e.QueryAttId).HasColumnName("QueryAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ctqid).HasColumnName("CTQID");

                entity.Property(e => e.DrawingFile).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNumber).HasMaxLength(100);

                entity.HasOne(d => d.Ctq)
                    .WithMany(p => p.TblSrconstructionTechnicalQueryAttachmentsTemp)
                    .HasForeignKey(d => d.Ctqid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueryAttachmentsTemp_tbl_SRConstructionTechnicalQueriesTemp");
            });

            modelBuilder.Entity<TblSrconstructionTechnicalQueryReplies>(entity =>
            {
                entity.HasKey(e => e.ReplyId);

                entity.ToTable("tbl_SRConstructionTechnicalQueryReplies");

                entity.Property(e => e.ReplyId).HasColumnName("ReplyID");

                entity.Property(e => e.AttentionReplyDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ctqid).HasColumnName("CTQID");

                entity.Property(e => e.InitiatorReplyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.QueryCloseDate).HasColumnType("datetime");

                entity.HasOne(d => d.Ctq)
                    .WithMany(p => p.TblSrconstructionTechnicalQueryReplies)
                    .HasForeignKey(d => d.Ctqid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueryReplies_tbl_SRConstructionTechnicalQueries");
            });

            modelBuilder.Entity<TblSrconstructionTechnicalQueryRepliesTemp>(entity =>
            {
                entity.HasKey(e => e.ReplyId);

                entity.ToTable("tbl_SRConstructionTechnicalQueryRepliesTemp");

                entity.Property(e => e.ReplyId).HasColumnName("ReplyID");

                entity.Property(e => e.AttentionReplyDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ctqid).HasColumnName("CTQID");

                entity.Property(e => e.InitiatorReplyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.QueryCloseDate).HasColumnType("datetime");

                entity.HasOne(d => d.Ctq)
                    .WithMany(p => p.TblSrconstructionTechnicalQueryRepliesTemp)
                    .HasForeignKey(d => d.Ctqid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SRConstructionTechnicalQueryRepliesTemp_tbl_SRConstructionTechnicalQueriesTemp");
            });

            modelBuilder.Entity<TblSrdailyReportHse>(entity =>
            {
                entity.HasKey(e => e.Drhseid);

                entity.ToTable("tbl_SRDailyReportHSE");

                entity.Property(e => e.Drhseid).HasColumnName("DRHSEID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DetailsStatistics)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.DrhseattId).HasColumnName("DRHSEAttID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Remarks).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportHse)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportHSE_tbl_CompanyInfo");

                entity.HasOne(d => d.Drhseatt)
                    .WithMany(p => p.TblSrdailyReportHse)
                    .HasForeignKey(d => d.DrhseattId)
                    .HasConstraintName("FK_tbl_SRDailyReportHSE_tbl_SRDailyReportHSEAttachments");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportHse)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportHSE_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportHseattachments>(entity =>
            {
                entity.HasKey(e => e.DrhseattId);

                entity.ToTable("tbl_SRDailyReportHSEAttachments");

                entity.Property(e => e.DrhseattId).HasColumnName("DRHSEAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PermitToWork).HasMaxLength(500);

                entity.Property(e => e.SecurityReport).HasMaxLength(500);
            });

            modelBuilder.Entity<TblSrdailyReportHseattachmentsTemp>(entity =>
            {
                entity.HasKey(e => e.DrhseattId);

                entity.ToTable("tbl_SRDailyReportHSEAttachmentsTemp");

                entity.Property(e => e.DrhseattId).HasColumnName("DRHSEAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PermitToWork).HasMaxLength(500);

                entity.Property(e => e.SecurityReport).HasMaxLength(500);
            });

            modelBuilder.Entity<TblSrdailyReportHsetemp>(entity =>
            {
                entity.HasKey(e => e.Drhseid);

                entity.ToTable("tbl_SRDailyReportHSETemp");

                entity.Property(e => e.Drhseid).HasColumnName("DRHSEID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DetailsStatistics)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.DrhseattId).HasColumnName("DRHSEAttID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Remarks).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportHsetemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportHSETemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Drhseatt)
                    .WithMany(p => p.TblSrdailyReportHsetemp)
                    .HasForeignKey(d => d.DrhseattId)
                    .HasConstraintName("FK_tbl_SRDailyReportHSETemp_tbl_SRDailyReportHSEAttachmentsTemp");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportHsetemp)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportHSETemp_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportOtherSiteReports>(entity =>
            {
                entity.HasKey(e => e.OsrepId);

                entity.ToTable("tbl_SRDailyReportOtherSiteReports");

                entity.Property(e => e.OsrepId).HasColumnName("OSRepID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.LogisticsReport).HasMaxLength(500);

                entity.Property(e => e.MaterialReport).HasMaxLength(500);

                entity.Property(e => e.Mocreport)
                    .HasColumnName("MOCReport")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Qaqcreport)
                    .HasColumnName("QAQCReport")
                    .HasMaxLength(500);

                entity.Property(e => e.SitePersonnelLogReport).HasMaxLength(500);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportOtherSiteReports)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportOtherSiteReports_tbl_CompanyInfo");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportOtherSiteReports)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportOtherSiteReports_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportOtherSiteReportsTemp>(entity =>
            {
                entity.HasKey(e => e.OsrepId);

                entity.ToTable("tbl_SRDailyReportOtherSiteReportsTemp");

                entity.Property(e => e.OsrepId).HasColumnName("OSRepID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.LogisticsReport).HasMaxLength(500);

                entity.Property(e => e.MaterialReport).HasMaxLength(500);

                entity.Property(e => e.Mocreport)
                    .HasColumnName("MOCReport")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Qaqcreport)
                    .HasColumnName("QAQCReport")
                    .HasMaxLength(500);

                entity.Property(e => e.SitePersonnelLogReport).HasMaxLength(500);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportOtherSiteReportsTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportOtherSiteReportsTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportOtherSiteReportsTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportOtherSiteReportsTemp_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportProgressMeasurementDetails>(entity =>
            {
                entity.HasKey(e => e.ProMeId);

                entity.ToTable("tbl_SRDailyReportProgressMeasurementDetails");

                entity.Property(e => e.ProMeId).HasColumnName("ProMeID");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CumPlannedProgress).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CumProgressActual).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProMeMasterId).HasColumnName("ProMeMasterID");

                entity.HasOne(d => d.ProMeMaster)
                    .WithMany(p => p.TblSrdailyReportProgressMeasurementDetails)
                    .HasForeignKey(d => d.ProMeMasterId)
                    .HasConstraintName("tbl_SRDailyReportProgressMeasurementDetails_tbl_SRDailyReportProgressMeasurementMaster");
            });

            modelBuilder.Entity<TblSrdailyReportProgressMeasurementDetailsTemp>(entity =>
            {
                entity.HasKey(e => e.ProMeId);

                entity.ToTable("tbl_SRDailyReportProgressMeasurementDetailsTemp");

                entity.Property(e => e.ProMeId).HasColumnName("ProMeID");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CumPlannedProgress).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CumProgressActual).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProMeMasterId).HasColumnName("ProMeMasterID");

                entity.HasOne(d => d.ProMeMaster)
                    .WithMany(p => p.TblSrdailyReportProgressMeasurementDetailsTemp)
                    .HasForeignKey(d => d.ProMeMasterId)
                    .HasConstraintName("tbl_SRDailyReportProgressMeasurementDetailsTemp_tbl_SRDailyReportProgressMeasurementMasterTemp");
            });

            modelBuilder.Entity<TblSrdailyReportProgressMeasurementMaster>(entity =>
            {
                entity.HasKey(e => e.ProMeMasterId);

                entity.ToTable("tbl_SRDailyReportProgressMeasurementMaster");

                entity.Property(e => e.ProMeMasterId).HasColumnName("ProMeMasterID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ConstructionActual).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Planned).HasColumnType("money");

                entity.Property(e => e.ProgressAt).HasMaxLength(100);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportProgressMeasurementMaster)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportProgressMeasurementMaster_tbl_CompanyInfo");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportProgressMeasurementMaster)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportProgressMeasurementMaster_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportProgressMeasurementMasterTemp>(entity =>
            {
                entity.HasKey(e => e.ProMeMasterId);

                entity.ToTable("tbl_SRDailyReportProgressMeasurementMasterTemp");

                entity.Property(e => e.ProMeMasterId).HasColumnName("ProMeMasterID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ConstructionActual).HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Planned).HasColumnType("money");

                entity.Property(e => e.ProgressAt).HasMaxLength(100);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportProgressMeasurementMasterTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportProgressMeasurementMasterTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportProgressMeasurementMasterTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportProgressMeasurementMasterTemp_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportingConstructionActivities>(entity =>
            {
                entity.HasKey(e => e.DrconActId);

                entity.ToTable("tbl_SRDailyReportingConstructionActivities");

                entity.Property(e => e.DrconActId).HasColumnName("DRConActID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ConstructionActivities).IsRequired();

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DailyProgress).IsRequired();

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.FollowingDayPlan).IsRequired();

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportingConstructionActivities)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportingConstructionActivities_tbl_CompanyInfo");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportingConstructionActivities)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportingConstructionActivities_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportingConstructionActivitiesTemp>(entity =>
            {
                entity.HasKey(e => e.DrconActId);

                entity.ToTable("tbl_SRDailyReportingConstructionActivitiesTemp");

                entity.Property(e => e.DrconActId).HasColumnName("DRConActID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ConstructionActivities).IsRequired();

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DailyProgress).IsRequired();

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.FollowingDayPlan).IsRequired();

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportingConstructionActivitiesTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportingConstructionActivitiesTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportingConstructionActivitiesTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportingConstructionActivitiesTemp_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportingDelays>(entity =>
            {
                entity.HasKey(e => e.DelayId);

                entity.ToTable("tbl_SRDailyReportingDelays");

                entity.Property(e => e.DelayId).HasColumnName("DelayID");

                entity.Property(e => e.Cause)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DescriptionofDelay).IsRequired();

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProMeMasterId).HasColumnName("ProMeMasterID");

                entity.HasOne(d => d.ProMeMaster)
                    .WithMany(p => p.TblSrdailyReportingDelays)
                    .HasForeignKey(d => d.ProMeMasterId)
                    .HasConstraintName("FK_tbl_SRDailyReportingDelays_tbl_SRDailyReportProgressMeasurementMaster");

                entity.HasOne(d => d.ResponsibleNavigation)
                    .WithMany(p => p.TblSrdailyReportingDelays)
                    .HasForeignKey(d => d.Responsible)
                    .HasConstraintName("FK_tbl_SRDailyReportingDelays_tbl_StaffBioData");
            });

            modelBuilder.Entity<TblSrdailyReportingDelaysTemp>(entity =>
            {
                entity.HasKey(e => e.DelayId);

                entity.ToTable("tbl_SRDailyReportingDelaysTemp");

                entity.Property(e => e.DelayId).HasColumnName("DelayID");

                entity.Property(e => e.Cause)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DescriptionofDelay).IsRequired();

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProMeMasterId).HasColumnName("ProMeMasterID");

                entity.HasOne(d => d.ProMeMaster)
                    .WithMany(p => p.TblSrdailyReportingDelaysTemp)
                    .HasForeignKey(d => d.ProMeMasterId)
                    .HasConstraintName("FK_tbl_SRDailyReportingDelaysTemp_tbl_SRDailyReportProgressMeasurementMasterTemp");

                entity.HasOne(d => d.ResponsibleNavigation)
                    .WithMany(p => p.TblSrdailyReportingDelaysTemp)
                    .HasForeignKey(d => d.Responsible)
                    .HasConstraintName("FK_tbl_SRDailyReportingDelaysTemp_tbl_StaffBioData");
            });

            modelBuilder.Entity<TblSrdailyReportingGenSumAttachments>(entity =>
            {
                entity.HasKey(e => e.DrgsattId);

                entity.ToTable("tbl_SRDailyReportingGenSumAttachments");

                entity.Property(e => e.DrgsattId).HasColumnName("DRGSAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.OtherAttachment).HasMaxLength(500);
            });

            modelBuilder.Entity<TblSrdailyReportingGenSumAttachmentsTemp>(entity =>
            {
                entity.HasKey(e => e.DrgsattId);

                entity.ToTable("tbl_SRDailyReportingGenSumAttachmentsTemp");

                entity.Property(e => e.DrgsattId).HasColumnName("DRGSAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.OtherAttachment).HasMaxLength(500);
            });

            modelBuilder.Entity<TblSrdailyReportingGeneralSummary>(entity =>
            {
                entity.HasKey(e => e.GenSumId);

                entity.ToTable("tbl_SRDailyReportingGeneralSummary");

                entity.Property(e => e.GenSumId).HasColumnName("GenSumID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.DrgsattId).HasColumnName("DRGSAttID");

                entity.Property(e => e.GeneralSummary).IsRequired();

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportingGeneralSummary)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportingGeneralSummary_tbl_CompanyInfo");

                entity.HasOne(d => d.Drgsatt)
                    .WithMany(p => p.TblSrdailyReportingGeneralSummary)
                    .HasForeignKey(d => d.DrgsattId)
                    .HasConstraintName("FK_tbl_SRDailyReportingGeneralSummary_tbl_SRDailyReportingGenSumAttachments");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportingGeneralSummary)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportingGeneralSummary_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportingGeneralSummaryTemp>(entity =>
            {
                entity.HasKey(e => e.GenSumId);

                entity.ToTable("tbl_SRDailyReportingGeneralSummaryTemp");

                entity.Property(e => e.GenSumId).HasColumnName("GenSumID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.DrgsattId).HasColumnName("DRGSAttID");

                entity.Property(e => e.GeneralSummary).IsRequired();

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportingGeneralSummaryTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportingGeneralSummaryTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Drgsatt)
                    .WithMany(p => p.TblSrdailyReportingGeneralSummaryTemp)
                    .HasForeignKey(d => d.DrgsattId)
                    .HasConstraintName("FK_tbl_SRDailyReportingGeneralSummaryTemp_tbl_SRDailyReportingGenSumAttachmentsTemp");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportingGeneralSummaryTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportingGeneralSummaryTemp_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportingIssues>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("tbl_SRDailyReportingIssues");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProMeMasterId).HasColumnName("ProMeMasterID");

                entity.HasOne(d => d.ProMeMaster)
                    .WithMany(p => p.TblSrdailyReportingIssues)
                    .HasForeignKey(d => d.ProMeMasterId)
                    .HasConstraintName("FK_tbl_SRDailyReportingIssues_tbl_SRDailyReportProgressMeasurementMaster");
            });

            modelBuilder.Entity<TblSrdailyReportingIssuesTemp>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("tbl_SRDailyReportingIssuesTemp");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProMeMasterId).HasColumnName("ProMeMasterID");

                entity.HasOne(d => d.ProMeMaster)
                    .WithMany(p => p.TblSrdailyReportingIssuesTemp)
                    .HasForeignKey(d => d.ProMeMasterId)
                    .HasConstraintName("FK_tbl_SRDailyReportingIssuesTemp_tbl_SRDailyReportProgressMeasurementMasterTemp");
            });

            modelBuilder.Entity<TblSrdailyReportingProgressPictures>(entity =>
            {
                entity.HasKey(e => e.Ppid);

                entity.ToTable("tbl_SRDailyReportingProgressPictures");

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportingProgressPictures)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportingProgressPictures_tbl_CompanyInfo");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportingProgressPictures)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportingProgressPictures_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdailyReportingProgressPicturesTemp>(entity =>
            {
                entity.HasKey(e => e.Ppid);

                entity.ToTable("tbl_SRDailyReportingProgressPicturesTemp");

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblSrdailyReportingProgressPicturesTemp)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_SRDailyReportingProgressPicturesTemp_tbl_CompanyInfo");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrdailyReportingProgressPicturesTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRDailyReportingProgressPicturesTemp_tbl_Projects");
            });

            modelBuilder.Entity<TblSrdrprogressPicturesAttachments>(entity =>
            {
                entity.HasKey(e => e.ProPicAttId);

                entity.ToTable("tbl_SRDRProgressPicturesAttachments");

                entity.Property(e => e.ProPicAttId).HasColumnName("ProPicAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.ProgressPictures).HasMaxLength(500);

                entity.HasOne(d => d.Pp)
                    .WithMany(p => p.TblSrdrprogressPicturesAttachments)
                    .HasForeignKey(d => d.Ppid)
                    .HasConstraintName("FK_tbl_SRDRProgressPicturesAttachments_tbl_SRDailyReportingProgressPictures");
            });

            modelBuilder.Entity<TblSrdrprogressPicturesAttachmentsTemp>(entity =>
            {
                entity.HasKey(e => e.ProPicAttId);

                entity.ToTable("tbl_SRDRProgressPicturesAttachmentsTemp");

                entity.Property(e => e.ProPicAttId).HasColumnName("ProPicAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.ProgressPictures).HasMaxLength(500);

                entity.HasOne(d => d.Pp)
                    .WithMany(p => p.TblSrdrprogressPicturesAttachmentsTemp)
                    .HasForeignKey(d => d.Ppid)
                    .HasConstraintName("FK_tbl_SRDRProgressPicturesAttachmentsTemp_tbl_SRDailyReportingProgressPicturesTemp");
            });

            modelBuilder.Entity<TblSrncrattachments>(entity =>
            {
                entity.HasKey(e => e.NcrattId);

                entity.ToTable("tbl_SRNCRAttachments");

                entity.Property(e => e.NcrattId).HasColumnName("NCRAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DescriptionDocuments).HasMaxLength(500);

                entity.Property(e => e.DrawingFile).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Ncrid).HasColumnName("NCRID");

                entity.Property(e => e.Ncrimages)
                    .HasColumnName("NCRImages")
                    .HasMaxLength(500);

                entity.Property(e => e.ReferenceNumber).HasMaxLength(100);

                entity.HasOne(d => d.Ncr)
                    .WithMany(p => p.TblSrncrattachments)
                    .HasForeignKey(d => d.Ncrid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SRNCRAttachments_tbl_SRNonConformanceReports");
            });

            modelBuilder.Entity<TblSrncrattachmentsTemp>(entity =>
            {
                entity.HasKey(e => e.NcrattId);

                entity.ToTable("tbl_SRNCRAttachmentsTemp");

                entity.Property(e => e.NcrattId).HasColumnName("NCRAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DescriptionDocuments).HasMaxLength(500);

                entity.Property(e => e.DrawingFile).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Ncrid).HasColumnName("NCRID");

                entity.Property(e => e.Ncrimages)
                    .HasColumnName("NCRImages")
                    .HasMaxLength(500);

                entity.Property(e => e.ReferenceNumber).HasMaxLength(100);

                entity.HasOne(d => d.Ncr)
                    .WithMany(p => p.TblSrncrattachmentsTemp)
                    .HasForeignKey(d => d.Ncrid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SRNCRAttachmentsTemp_tbl_SRNonConformanceReportsTemp");
            });

            modelBuilder.Entity<TblSrnonConformanceReports>(entity =>
            {
                entity.HasKey(e => e.Ncrid);

                entity.ToTable("tbl_SRNonConformanceReports");

                entity.Property(e => e.Ncrid).HasColumnName("NCRID");

                entity.Property(e => e.AreaModuleNumber).HasMaxLength(100);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ContractorProposedDisposition).HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DispositionSubmittedBy).HasMaxLength(200);

                entity.Property(e => e.DispositionSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.IssuedBy).HasMaxLength(100);

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.Item).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ReportNumber).HasMaxLength(100);

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SystemsSubSystems).HasMaxLength(100);

                entity.Property(e => e.TagNumber).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblSrnonConformanceReports)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReports_tbl_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblSrnonConformanceReports)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReports_tbl_Country");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrnonConformanceReports)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReports_tbl_Projects");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblSrnonConformanceReports)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReports_tbl_State");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSrnonConformanceReports)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReports_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblSrnonConformanceReportsTemp>(entity =>
            {
                entity.HasKey(e => e.Ncrid);

                entity.ToTable("tbl_SRNonConformanceReportsTemp");

                entity.Property(e => e.Ncrid).HasColumnName("NCRID");

                entity.Property(e => e.AreaModuleNumber).HasMaxLength(100);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ContractorProposedDisposition).HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DispositionSubmittedBy).HasMaxLength(200);

                entity.Property(e => e.DispositionSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.IssuedBy).HasMaxLength(100);

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.Item).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ReportNumber).HasMaxLength(100);

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SystemsSubSystems).HasMaxLength(100);

                entity.Property(e => e.TagNumber).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblSrnonConformanceReportsTemp)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReportsTemp_tbl_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblSrnonConformanceReportsTemp)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReportsTemp_tbl_Country");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TblSrnonConformanceReportsTemp)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReportsTemp_tbl_Projects");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblSrnonConformanceReportsTemp)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReportsTemp_tbl_State");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSrnonConformanceReportsTemp)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_SRNonConformanceReportsTemp_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblStaffBioData>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("tbl_StaffBioData");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AspnetUserId)
                    .HasColumnName("ASPNetUserID")
                    .HasMaxLength(450);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.OfficeEmailAddress).HasMaxLength(100);

                entity.Property(e => e.OfficePhoneNumber).HasMaxLength(50);

                entity.Property(e => e.OtherName).HasMaxLength(50);

                entity.Property(e => e.PersonalEmailAddress).HasMaxLength(100);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ProfileImage).HasMaxLength(100);

                entity.Property(e => e.StaffNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.AspnetUser)
                    .WithMany(p => p.TblStaffBioData)
                    .HasForeignKey(d => d.AspnetUserId)
                    .HasConstraintName("FK_tbl_StaffBioData_AspNetUsers");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblStaffBioData)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_StaffBioData_tbl_City");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblStaffBioData)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tbl_StaffBioData_tbl_CompanyInfo");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblStaffBioData)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_StaffBioData_tbl_Country");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblStaffBioData)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_tbl_StaffBioData_tbl_Departments");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.TblStaffBioData)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_tbl_StaffBioData_tbl_Position");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblStaffBioData)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_StaffBioData_tbl_State");
            });

            modelBuilder.Entity<TblStaffRoles>(entity =>
            {
                entity.HasKey(e => e.StaffRoleId);

                entity.ToTable("tbl_StaffRoles");

                entity.Property(e => e.StaffRoleId).HasColumnName("StaffRoleID");

                entity.Property(e => e.AuthoriserId).HasColumnName("AuthoriserID");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.WfdefId).HasColumnName("WFDefID");

                entity.HasOne(d => d.Authoriser)
                    .WithMany(p => p.TblStaffRolesAuthoriser)
                    .HasForeignKey(d => d.AuthoriserId)
                    .HasConstraintName("FK_tbl_StaffRoles_tbl_StaffBioDataAuthoriser");

                entity.HasOne(d => d.Checker)
                    .WithMany(p => p.TblStaffRolesChecker)
                    .HasForeignKey(d => d.CheckerId)
                    .HasConstraintName("FK_tbl_StaffRoles_tbl_StaffBioDataChecker");

                entity.HasOne(d => d.Wfdef)
                    .WithMany(p => p.TblStaffRoles)
                    .HasForeignKey(d => d.WfdefId)
                    .HasConstraintName("FK_tbl_StaffRoles_tbl_WorkflowProcessDef");
            });

            modelBuilder.Entity<TblStaffStrengthComp>(entity =>
            {
                entity.HasKey(e => e.StaffStrCompId);

                entity.ToTable("tbl_StaffStrengthComp");

                entity.Property(e => e.StaffStrCompId).HasColumnName("StaffStrCompID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblStaffStrengthComp)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_StaffStrengthComp_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblStaffStrengthCompPerm>(entity =>
            {
                entity.HasKey(e => e.StaffStrCompId);

                entity.ToTable("tbl_StaffStrengthCompPerm");

                entity.Property(e => e.StaffStrCompId).HasColumnName("StaffStrCompID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblStaffStrengthCompPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_StaffStrengthCompPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblState>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("tbl_State");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblState)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_State_tbl_Country");
            });

            modelBuilder.Entity<TblSubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCategoryId);

                entity.ToTable("tbl_SubCategory");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblSubContractedServices>(entity =>
            {
                entity.HasKey(e => e.SubServId);

                entity.ToTable("tbl_SubContractedServices");

                entity.Property(e => e.SubServId).HasColumnName("SubServID");

                entity.Property(e => e.PercentageOutsourced).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblSubContractedServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_tbl_SubContractedServices_tbl_Services");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSubContractedServices)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_SubContractedServices_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblSubContractedServicesPerm>(entity =>
            {
                entity.HasKey(e => e.SubServId);

                entity.ToTable("tbl_SubContractedServicesPerm");

                entity.Property(e => e.SubServId).HasColumnName("SubServID");

                entity.Property(e => e.PercentageOutsourced).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblSubContractedServicesPerm)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_tbl_SubContractedServicesPerm_tbl_Services");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSubContractedServicesPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_SubContractedServicesPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblSubContractorDetails>(entity =>
            {
                entity.HasKey(e => e.SubConId)
                    .HasName("PK_tbl_SubContractedDetails");

                entity.ToTable("tbl_SubContractorDetails");

                entity.Property(e => e.SubConId).HasColumnName("SubConID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.SubConAddress).HasMaxLength(500);

                entity.Property(e => e.SubConName).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblSubContractorDetails)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_SubContractedDetails_tbl_Country");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSubContractorDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_SubContractorDetails_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblSubContractorDetailsPerm>(entity =>
            {
                entity.HasKey(e => e.SubConId)
                    .HasName("PK_tbl_SubContractedDetailsPerm");

                entity.ToTable("tbl_SubContractorDetailsPerm");

                entity.Property(e => e.SubConId).HasColumnName("SubConID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.SubConAddress).HasMaxLength(500);

                entity.Property(e => e.SubConName).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSubContractorDetailsPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_SubContractorDetailsPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblSubsidiaryCompany>(entity =>
            {
                entity.HasKey(e => e.SubsidiaryId);

                entity.ToTable("tbl_SubsidiaryCompany");

                entity.Property(e => e.SubsidiaryId).HasColumnName("SubsidiaryID");

                entity.Property(e => e.SubsidiaryCompanyName).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSubsidiaryCompany)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SubsidiaryCompany_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblSubsidiaryCompanyPerm>(entity =>
            {
                entity.HasKey(e => e.SubsidiaryId);

                entity.ToTable("tbl_SubsidiaryCompanyPerm");

                entity.Property(e => e.SubsidiaryId).HasColumnName("SubsidiaryID");

                entity.Property(e => e.SubsidiaryCompanyName).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSubsidiaryCompanyPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SubsidiaryCompanyPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblSupplierCategorization>(entity =>
            {
                entity.HasKey(e => e.SupCatId);

                entity.ToTable("tbl_SupplierCategorization");

                entity.Property(e => e.SupCatId).HasColumnName("SupCatID");

                entity.Property(e => e.CatSpecId).HasColumnName("CatSpecID");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DprcatId).HasColumnName("DPRCatID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductServiceCategoryId).HasColumnName("ProductServiceCategoryID");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("ServiceCategoryID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.CatSpec)
                    .WithMany(p => p.TblSupplierCategorization)
                    .HasForeignKey(d => d.CatSpecId)
                    .HasConstraintName("FK_tbl_SupplierCategorization_tbl_CategorySpecialization");

                entity.HasOne(d => d.Dprcat)
                    .WithMany(p => p.TblSupplierCategorization)
                    .HasForeignKey(d => d.DprcatId)
                    .HasConstraintName("FK_tbl_SupplierCategorization_tbl_DPRCategory");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.TblSupplierCategorization)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_tbl_SupplierCategorization_tbl_ProductCategory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSupplierCategorization)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_SupplierCategorization_tbl_Products");

                entity.HasOne(d => d.ProductServiceCategory)
                    .WithMany(p => p.TblSupplierCategorization)
                    .HasForeignKey(d => d.ProductServiceCategoryId)
                    .HasConstraintName("FK_tbl_SupplierCategorization_tbl_ProductServiceCategory");

                entity.HasOne(d => d.ServiceCategory)
                    .WithMany(p => p.TblSupplierCategorization)
                    .HasForeignKey(d => d.ServiceCategoryId)
                    .HasConstraintName("FK_tbl_SupplierCategorization_tbl_ServicesCategory");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblSupplierCategorization)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_tbl_SupplierCategorization_tbl_Services");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSupplierCategorization)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SupplierCategorization_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblSupplierCategorizationPerm>(entity =>
            {
                entity.HasKey(e => e.SupCatId);

                entity.ToTable("tbl_SupplierCategorizationPerm");

                entity.Property(e => e.SupCatId).HasColumnName("SupCatID");

                entity.Property(e => e.CatSpecId).HasColumnName("CatSpecID");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DprcatId).HasColumnName("DPRCatID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductServiceCategoryId).HasColumnName("ProductServiceCategoryID");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("ServiceCategoryID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.CatSpec)
                    .WithMany(p => p.TblSupplierCategorizationPerm)
                    .HasForeignKey(d => d.CatSpecId)
                    .HasConstraintName("FK_tbl_SupplierCategorizationPerm_tbl_CategorySpecialization");

                entity.HasOne(d => d.Dprcat)
                    .WithMany(p => p.TblSupplierCategorizationPerm)
                    .HasForeignKey(d => d.DprcatId)
                    .HasConstraintName("FK_tbl_SupplierCategorizationPerm_tbl_DPRCategory");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.TblSupplierCategorizationPerm)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_tbl_SupplierCategorizationPerm_tbl_ProductCategory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSupplierCategorizationPerm)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_SupplierCategorizationPerm_tbl_Products");

                entity.HasOne(d => d.ProductServiceCategory)
                    .WithMany(p => p.TblSupplierCategorizationPerm)
                    .HasForeignKey(d => d.ProductServiceCategoryId)
                    .HasConstraintName("FK_tbl_SupplierCategorizationPerm_tbl_ProductServiceCategory");

                entity.HasOne(d => d.ServiceCategory)
                    .WithMany(p => p.TblSupplierCategorizationPerm)
                    .HasForeignKey(d => d.ServiceCategoryId)
                    .HasConstraintName("FK_tbl_SupplierCategorizationPerm_tbl_ServicesCategory");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblSupplierCategorizationPerm)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_tbl_SupplierCategorizationPerm_tbl_Services");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSupplierCategorizationPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SupplierCategorizationPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblSupplierIdentification>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("tbl_SupplierIdentification");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CompanyRegNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyWebsiteUrl).HasColumnName("CompanyWebsiteURL");

                entity.Property(e => e.CorporateAffairsCommisionNo).HasMaxLength(20);

                entity.Property(e => e.DateofCreation).HasColumnType("datetime");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.HeadOfficeAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.TblSupplierIdentification)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SupplierIdentification_tbl_FormIdentification");
            });

            modelBuilder.Entity<TblSupplierIdentificationPerm>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("tbl_SupplierIdentificationPerm");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CompanyRegNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyWebsiteUrl).HasColumnName("CompanyWebsiteURL");

                entity.Property(e => e.CorporateAffairsCommisionNo).HasMaxLength(20);

                entity.Property(e => e.DateofCreation).HasColumnType("datetime");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.HeadOfficeAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.TblSupplierIdentificationPerm)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SupplierIdentificationPerm_tbl_FormIdentificationPerm");
            });

            modelBuilder.Entity<TblSupplierOwnership>(entity =>
            {
                entity.HasKey(e => e.OwnershipId);

                entity.ToTable("tbl_SupplierOwnership");

                entity.Property(e => e.OwnershipId).HasColumnName("OwnershipID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.MainShareholder).HasMaxLength(500);

                entity.Property(e => e.Shareholding).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblSupplierOwnership)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_SupplierOwnership_tbl_Country");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSupplierOwnership)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SupplierOwnership_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblSupplierOwnershipPerm>(entity =>
            {
                entity.HasKey(e => e.OwnershipId);

                entity.ToTable("tbl_SupplierOwnershipPerm");

                entity.Property(e => e.OwnershipId).HasColumnName("OwnershipID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.MainShareholder).HasMaxLength(500);

                entity.Property(e => e.Shareholding).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblSupplierOwnershipPerm)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_SupplierOwnershipPerm_tbl_Country");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSupplierOwnershipPerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SupplierOwnershipPerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblSupplierProfile>(entity =>
            {
                entity.HasKey(e => e.SupplierProfileId);

                entity.ToTable("tbl_SupplierProfile");

                entity.Property(e => e.SupplierProfileId).HasColumnName("SupplierProfileID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSupplierProfile)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SupplierProfile_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblSupplierProfilePerm>(entity =>
            {
                entity.HasKey(e => e.SupplierProfileId);

                entity.ToTable("tbl_SupplierProfilePerm");

                entity.Property(e => e.SupplierProfileId).HasColumnName("SupplierProfileID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblSupplierProfilePerm)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SupplierProfilePerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblTenderAttachements>(entity =>
            {
                entity.HasKey(e => e.TenderAttId);

                entity.ToTable("tbl_TenderAttachements");

                entity.Property(e => e.TenderAttId).HasColumnName("TenderAttID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.DocumentTitle).HasMaxLength(200);

                entity.Property(e => e.DocumentUrl)
                    .HasColumnName("DocumentURL")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoMasterId).HasColumnName("QuoMasterID");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.TblTenderAttachements)
                    .HasForeignKey(d => d.DocTypeId)
                    .HasConstraintName("FK_tbl_TenderAttachements_tbl_DocumentType");

                entity.HasOne(d => d.QuoMaster)
                    .WithMany(p => p.TblTenderAttachements)
                    .HasForeignKey(d => d.QuoMasterId)
                    .HasConstraintName("FK_tbl_TenderAttachements_tbl_QuotationMaster");
            });

            modelBuilder.Entity<TblThirdPartyReference>(entity =>
            {
                entity.HasKey(e => e.TprId);

                entity.ToTable("tbl_ThirdPartyReference");

                entity.Property(e => e.TprId).HasColumnName("TPR_ID");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.ThirdPartyReference).HasMaxLength(500);

                entity.Property(e => e.TprAddress)
                    .HasColumnName("TPR_Address")
                    .HasMaxLength(500);

                entity.Property(e => e.TprEmailAddress)
                    .HasColumnName("TPR_EmailAddress")
                    .HasMaxLength(100);

                entity.Property(e => e.TprName)
                    .HasColumnName("TPR_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.TprOrganization)
                    .HasColumnName("TPR_Organization")
                    .HasMaxLength(100);

                entity.Property(e => e.TprPhoneNumber)
                    .HasColumnName("TPR_PhoneNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.TprWorkPhoneNumber)
                    .HasColumnName("TPR_WorkPhoneNumber")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.TblThirdPartyReference)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_tbl_ThirdPartyReference_tbl_FormIdentification");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblThirdPartyReference)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_ThirdPartyReference_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblThirdPartyReferencePerm>(entity =>
            {
                entity.HasKey(e => e.TprId);

                entity.ToTable("tbl_ThirdPartyReferencePerm");

                entity.Property(e => e.TprId).HasColumnName("TPR_ID");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.ThirdPartyReference).HasMaxLength(500);

                entity.Property(e => e.TprAddress)
                    .HasColumnName("TPR_Address")
                    .HasMaxLength(500);

                entity.Property(e => e.TprEmailAddress)
                    .HasColumnName("TPR_EmailAddress")
                    .HasMaxLength(100);

                entity.Property(e => e.TprName)
                    .HasColumnName("TPR_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.TprOrganization)
                    .HasColumnName("TPR_Organization")
                    .HasMaxLength(100);

                entity.Property(e => e.TprPhoneNumber)
                    .HasColumnName("TPR_PhoneNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.TprWorkPhoneNumber)
                    .HasColumnName("TPR_WorkPhoneNumber")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.TblThirdPartyReferencePerm)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_tbl_ThirdPartyReferencePerm_tbl_FormIdentificationPerm");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblThirdPartyReferencePerm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_ThirdPartyReferencePerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblTypicalSubcontractedScope>(entity =>
            {
                entity.HasKey(e => e.SubConScopeId);

                entity.ToTable("tbl_TypicalSubcontractedScope");

                entity.Property(e => e.SubConScopeId).HasColumnName("SubConScopeID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SubConAddress).HasMaxLength(500);

                entity.Property(e => e.SubConName).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblTypicalSubcontractedScope)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_TypicalSubcontractedScope_tbl_Country");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblTypicalSubcontractedScope)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_TypicalSubcontractedScope_tbl_Products");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblTypicalSubcontractedScope)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_TypicalSubcontractedScope_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblTypicalSubcontractedScopePerm>(entity =>
            {
                entity.HasKey(e => e.SubConScopeId);

                entity.ToTable("tbl_TypicalSubcontractedScopePerm");

                entity.Property(e => e.SubConScopeId).HasColumnName("SubConScopeID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SubConAddress).HasMaxLength(500);

                entity.Property(e => e.SubConName).HasMaxLength(500);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblTypicalSubcontractedScopePerm)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_tbl_TypicalSubContractedScopePerm_tbl_Country");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblTypicalSubcontractedScopePerm)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_TypicalSubContractedScopePerm_tbl_Products");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblTypicalSubcontractedScopePerm)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_TypicalSubContractedScopePerm_tbl_SupplierIdentificationPerm");
            });

            modelBuilder.Entity<TblUnits>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("tbl_Units");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.UnitCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblVendorData>(entity =>
            {
                entity.HasKey(e => e.VenDataId);

                entity.ToTable("tbl_VendorData");

                entity.Property(e => e.VenDataId).HasColumnName("VenDataID");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.AspnetUserId)
                    .HasColumnName("ASPNetUSerID")
                    .HasMaxLength(450);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.AspnetUser)
                    .WithMany(p => p.TblVendorData)
                    .HasForeignKey(d => d.AspnetUserId)
                    .HasConstraintName("FK_tbl_VendorData_AspNetUsers");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblVendorData)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_tbl_VendorData_tbl_City");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblVendorData)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tbl_VendorData_tbl_State");
            });

            modelBuilder.Entity<TblVendorDepartments>(entity =>
            {
                entity.HasKey(e => e.VenDepId);

                entity.ToTable("tbl_VendorDepartments");

                entity.Property(e => e.VenDepId).HasColumnName("VenDepID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.VenDepCode).HasMaxLength(10);

                entity.Property(e => e.VenDepTitle).HasMaxLength(200);
            });

            modelBuilder.Entity<TblVendorPositions>(entity =>
            {
                entity.HasKey(e => e.VenPosId);

                entity.ToTable("tbl_VendorPositions");

                entity.Property(e => e.VenPosId).HasColumnName("VenPosID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.VenPosCode).HasMaxLength(10);

                entity.Property(e => e.VenPosTitle).HasMaxLength(200);
            });

            modelBuilder.Entity<TblVendorProjectConsortium>(entity =>
            {
                entity.HasKey(e => e.VenProConId);

                entity.ToTable("tbl_VendorProjectConsortium");

                entity.Property(e => e.VenProConId).HasColumnName("VenProConID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectConsortiumAddress).HasMaxLength(500);

                entity.Property(e => e.ProjectConsortiumName).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblVendorProjectConsortium)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_tbl_VendorProjectConsortium_tbl_SupplierIdentification");
            });

            modelBuilder.Entity<TblVendorRegFormApproval>(entity =>
            {
                entity.HasKey(e => e.VendorApprovalId);

                entity.ToTable("tbl_VendorRegFormApproval");

                entity.Property(e => e.VendorApprovalId).HasColumnName("VendorApprovalID");

                entity.Property(e => e.AdforeignCompanyName)
                    .HasColumnName("ADForeignCompanyName")
                    .HasMaxLength(100);

                entity.Property(e => e.AdforeignCompanyOther).HasColumnName("ADForeignCompanyOther");

                entity.Property(e => e.AdforeignCompanyProductSupplied)
                    .HasColumnName("ADForeignCompanyProductSupplied")
                    .HasMaxLength(100);

                entity.Property(e => e.AdforeignCompanyStatus)
                    .HasColumnName("ADForeignCompanyStatus")
                    .HasMaxLength(20);

                entity.Property(e => e.ApprovalStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedBy).HasMaxLength(200);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BankReference).HasMaxLength(100);

                entity.Property(e => e.BusinessExCompanyWorkedWith).HasMaxLength(100);

                entity.Property(e => e.BusinessExContinuityPolicy).HasMaxLength(100);

                entity.Property(e => e.BusinessExHasContinuityPolicy).HasMaxLength(10);

                entity.Property(e => e.BusinessExRegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.BusinessExScopeCovered).HasMaxLength(500);

                entity.Property(e => e.BusinessExTimeFrame).HasMaxLength(10);

                entity.Property(e => e.BusinessExTransactionReference).HasMaxLength(100);

                entity.Property(e => e.CodeofConduct).HasMaxLength(100);

                entity.Property(e => e.CorporateDistinctives).HasMaxLength(200);

                entity.Property(e => e.CsrsocRespEthHumanLaborLaws)
                    .HasColumnName("CSRSocRespEthHumanLaborLaws")
                    .HasMaxLength(100);

                entity.Property(e => e.Cymfgffcity)
                    .HasColumnName("CYMFGFFCity")
                    .HasMaxLength(50);

                entity.Property(e => e.CymfgfffactoryArea)
                    .HasColumnName("CYMFGFFFactoryArea")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CymfgffplantEquipmentNumber).HasColumnName("CYMFGFFPlantEquipmentNumber");

                entity.Property(e => e.CymfgffplantEquipmentType)
                    .HasColumnName("CYMFGFFPlantEquipmentType")
                    .HasMaxLength(50);

                entity.Property(e => e.Cymfgffutilization)
                    .HasColumnName("CYMFGFFUtilization")
                    .HasMaxLength(100);

                entity.Property(e => e.DirectServiceScopeMaterials).HasMaxLength(100);

                entity.Property(e => e.DirectServiceScopeSubCategories).HasMaxLength(100);

                entity.Property(e => e.FinancialAuditorAddress).HasMaxLength(200);

                entity.Property(e => e.FinancialAuditorContactNumber).HasMaxLength(20);

                entity.Property(e => e.FinancialAuditorName).HasMaxLength(100);

                entity.Property(e => e.FinancialStatementTaxIdnumber)
                    .HasColumnName("FinancialStatementTaxIDNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.FinancialStatementYear1).HasMaxLength(100);

                entity.Property(e => e.FinancialStatementYear2).HasMaxLength(100);

                entity.Property(e => e.FinancialStatementYear3).HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormIdentificationDate).HasColumnType("datetime");

                entity.Property(e => e.FormIdentificationEmailAddress).HasMaxLength(100);

                entity.Property(e => e.FormIdentificationName).HasMaxLength(100);

                entity.Property(e => e.FormIdentificationPhoneNumber).HasMaxLength(20);

                entity.Property(e => e.FormIdentificationPosition).HasMaxLength(100);

                entity.Property(e => e.FormIdentificationWorkPhoneNumber).HasMaxLength(20);

                entity.Property(e => e.HealthSafetyEnvironmentPolicy).HasMaxLength(100);

                entity.Property(e => e.HsecertficationValidityDate)
                    .HasColumnName("HSECertficationValidityDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HsecertificationCertAuthority)
                    .HasColumnName("HSECertificationCertAuthority")
                    .HasMaxLength(100);

                entity.Property(e => e.HsecertificationName)
                    .HasColumnName("HSECertificationName")
                    .HasMaxLength(100);

                entity.Property(e => e.HsecompanyKpi)
                    .HasColumnName("HSECompanyKPI")
                    .HasMaxLength(100);

                entity.Property(e => e.HsecompanyYearN1results)
                    .HasColumnName("HSECompanyYearN1Results")
                    .HasMaxLength(100);

                entity.Property(e => e.HsefaxNumber)
                    .HasColumnName("HSEFaxNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.HsemanagerEmail)
                    .HasColumnName("HSEManagerEmail")
                    .HasMaxLength(200);

                entity.Property(e => e.HsemanagerName)
                    .HasColumnName("HSEManagerName")
                    .HasMaxLength(100);

                entity.Property(e => e.HsephoneNumber)
                    .HasColumnName("HSEPhoneNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.HsestaffTrainingPolicy)
                    .HasColumnName("HSEStaffTrainingPolicy")
                    .HasMaxLength(100);

                entity.Property(e => e.HsethirdPartyAudit)
                    .HasColumnName("HSEThirdPartyAudit")
                    .HasMaxLength(100);

                entity.Property(e => e.HseworkPhoneNumber)
                    .HasColumnName("HSEWorkPhoneNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.IsListedStockMarket).HasMaxLength(10);

                entity.Property(e => e.KnowledgeofDgssystemsContractNo)
                    .HasColumnName("KnowledgeofDGSSystemsContractNo")
                    .HasMaxLength(50);

                entity.Property(e => e.KnowledgeofDgssystemsDgsref)
                    .HasColumnName("KnowledgeofDGSSystemsDGSRef")
                    .HasMaxLength(50);

                entity.Property(e => e.KnowledgeofDgssystemsProdEquServ)
                    .HasColumnName("KnowledgeofDGSSystemsProdEquServ")
                    .HasMaxLength(100);

                entity.Property(e => e.KnowledgeofDgssystemsStartDate)
                    .HasColumnName("KnowledgeofDGSSystemsStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MainContactPersonEmail).HasMaxLength(50);

                entity.Property(e => e.MainContactPersonName).HasMaxLength(100);

                entity.Property(e => e.MainContactPersonPhone).HasMaxLength(20);

                entity.Property(e => e.MainContactPersonPosition).HasMaxLength(50);

                entity.Property(e => e.MainContactPersonWorkPhone).HasMaxLength(20);

                entity.Property(e => e.OwnershipMainShareholders).HasMaxLength(100);

                entity.Property(e => e.OwnershipNationality).HasMaxLength(50);

                entity.Property(e => e.PercentageShareholding).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductQualityManagement).HasMaxLength(100);

                entity.Property(e => e.QualityCertficationValidityDate).HasColumnType("datetime");

                entity.Property(e => e.QualityCertificationCertOrganization).HasMaxLength(100);

                entity.Property(e => e.QualityCertificationName).HasMaxLength(100);

                entity.Property(e => e.QualityManagement).HasMaxLength(100);

                entity.Property(e => e.QualityManagerEmail).HasMaxLength(200);

                entity.Property(e => e.QualityManagerFaxNumber).HasMaxLength(20);

                entity.Property(e => e.QualityManagerName).HasMaxLength(100);

                entity.Property(e => e.QualityManagerPhoneNumber).HasMaxLength(20);

                entity.Property(e => e.QualityManagerWorkPhoneNo).HasMaxLength(20);

                entity.Property(e => e.QualityPolicy).HasMaxLength(100);

                entity.Property(e => e.SpdirectServiceScopeService)
                    .HasColumnName("SPDirectServiceScopeService")
                    .HasMaxLength(100);

                entity.Property(e => e.SpdirectServiceScopeServiceDetails).HasColumnName("SPDirectServiceScopeServiceDetails");

                entity.Property(e => e.SpofficeServiceCenterCity)
                    .HasColumnName("SPOfficeServiceCenterCity")
                    .HasMaxLength(50);

                entity.Property(e => e.SpofficeServiceCenterCountry)
                    .HasColumnName("SPOfficeServiceCenterCountry")
                    .HasMaxLength(50);

                entity.Property(e => e.SpsubContractedServices)
                    .HasColumnName("SPSubContractedServices")
                    .HasMaxLength(100);

                entity.Property(e => e.SpsubContractedServicesPercOutsourced)
                    .HasColumnName("SPSubContractedServicesPercOutsourced")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SpsubContractorAddress)
                    .HasColumnName("SPSubContractorAddress")
                    .HasMaxLength(200);

                entity.Property(e => e.SpsubContractorIsLocal).HasColumnName("SPSubContractorIsLocal");

                entity.Property(e => e.SpsubContractorName)
                    .HasColumnName("SPSubContractorName")
                    .HasMaxLength(100);

                entity.Property(e => e.SpsubContractorNationality)
                    .HasColumnName("SPSubContractorNationality")
                    .HasMaxLength(50);

                entity.Property(e => e.StaffTrainingPolicy).HasMaxLength(100);

                entity.Property(e => e.StaffTrainingPolicyThirdPartyAudit).HasMaxLength(100);

                entity.Property(e => e.StockMarketInfo).HasMaxLength(100);

                entity.Property(e => e.SubsidiaryCompanyName).HasMaxLength(100);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.ThirdPartyRefContactNo).HasMaxLength(20);

                entity.Property(e => e.ThirdPartyRefEmail).HasMaxLength(50);

                entity.Property(e => e.ThirdPartyRefName).HasMaxLength(100);

                entity.Property(e => e.ThirdPartyRefOrgAddress).HasMaxLength(200);

                entity.Property(e => e.TypicalSubContractedScopeAddress).HasMaxLength(100);

                entity.Property(e => e.TypicalSubContractedScopeName).HasMaxLength(100);

                entity.Property(e => e.TypicalSubContractedScopeNationality).HasMaxLength(50);

                entity.Property(e => e.TypicalSubContractedScopeProducts).HasMaxLength(50);

                entity.Property(e => e.VendorCompanyDateofCreation).HasColumnType("datetime");

                entity.Property(e => e.VendorCompanyDepartment).HasMaxLength(100);

                entity.Property(e => e.VendorCompanyName).HasMaxLength(100);

                entity.Property(e => e.VendorCompanyProfile).HasMaxLength(100);

                entity.Property(e => e.VendorCompanyRegistrationNumber).HasMaxLength(20);

                entity.Property(e => e.VendorCompanyWebsiteAddress).HasMaxLength(50);

                entity.Property(e => e.VendorCorporateAffairsCommisionNo).HasMaxLength(20);

                entity.Property(e => e.VendorFraudMalpracticePolicy).HasMaxLength(100);

                entity.Property(e => e.VendorHeadOfficeAddress).HasMaxLength(200);

                entity.Property(e => e.VendorMainCustomerCountry).HasMaxLength(50);

                entity.Property(e => e.VendorMainCustomerName).HasMaxLength(100);

                entity.Property(e => e.VendorMainCustomerValue).HasMaxLength(50);

                entity.Property(e => e.VendorMissionVisionStatement).HasMaxLength(100);

                entity.Property(e => e.VendorNatureofBusiness).HasMaxLength(500);

                entity.Property(e => e.VendorOrganizationChart).HasMaxLength(100);

                entity.Property(e => e.VendorThirdPartySocialAudit).HasMaxLength(100);

                entity.Property(e => e.VendorUsername).HasMaxLength(100);
            });

            modelBuilder.Entity<TblWorkflowProcessDef>(entity =>
            {
                entity.HasKey(e => e.WfdefId);

                entity.ToTable("tbl_WorkflowProcessDef");

                entity.Property(e => e.WfdefId).HasColumnName("WFDefID");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
