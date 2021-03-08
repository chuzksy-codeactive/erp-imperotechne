using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblCity
    {
        public TblCity()
        {
            TblCyMfgFf = new HashSet<TblCyMfgFf>();
            TblCyMfgFfperm = new HashSet<TblCyMfgFfperm>();
            TblEndUserRequisitionServices = new HashSet<TblEndUserRequisitionServices>();
            TblMtoelectricalFormDetails = new HashSet<TblMtoelectricalFormDetails>();
            TblMtoelectricalFormDetailsTemp = new HashSet<TblMtoelectricalFormDetailsTemp>();
            TblOfficeServiceCl = new HashSet<TblOfficeServiceCl>();
            TblOfficeServiceClperm = new HashSet<TblOfficeServiceClperm>();
            TblSrconstructionTechnicalQueries = new HashSet<TblSrconstructionTechnicalQueries>();
            TblSrconstructionTechnicalQueriesTemp = new HashSet<TblSrconstructionTechnicalQueriesTemp>();
            TblSrnonConformanceReports = new HashSet<TblSrnonConformanceReports>();
            TblSrnonConformanceReportsTemp = new HashSet<TblSrnonConformanceReportsTemp>();
            TblStaffBioData = new HashSet<TblStaffBioData>();
            TblVendorData = new HashSet<TblVendorData>();
        }

        public int CityId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public int? StateId { get; set; }

        public virtual TblState State { get; set; }
        public virtual ICollection<TblCyMfgFf> TblCyMfgFf { get; set; }
        public virtual ICollection<TblCyMfgFfperm> TblCyMfgFfperm { get; set; }
        public virtual ICollection<TblEndUserRequisitionServices> TblEndUserRequisitionServices { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetails> TblMtoelectricalFormDetails { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetailsTemp> TblMtoelectricalFormDetailsTemp { get; set; }
        public virtual ICollection<TblOfficeServiceCl> TblOfficeServiceCl { get; set; }
        public virtual ICollection<TblOfficeServiceClperm> TblOfficeServiceClperm { get; set; }
        public virtual ICollection<TblSrconstructionTechnicalQueries> TblSrconstructionTechnicalQueries { get; set; }
        public virtual ICollection<TblSrconstructionTechnicalQueriesTemp> TblSrconstructionTechnicalQueriesTemp { get; set; }
        public virtual ICollection<TblSrnonConformanceReports> TblSrnonConformanceReports { get; set; }
        public virtual ICollection<TblSrnonConformanceReportsTemp> TblSrnonConformanceReportsTemp { get; set; }
        public virtual ICollection<TblStaffBioData> TblStaffBioData { get; set; }
        public virtual ICollection<TblVendorData> TblVendorData { get; set; }
    }
}
