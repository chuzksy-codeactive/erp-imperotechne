using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblState
    {
        public TblState()
        {
            TblCity = new HashSet<TblCity>();
            TblEndUserRequisitionServices = new HashSet<TblEndUserRequisitionServices>();
            TblMtoelectricalFormDetails = new HashSet<TblMtoelectricalFormDetails>();
            TblMtoelectricalFormDetailsTemp = new HashSet<TblMtoelectricalFormDetailsTemp>();
            TblSrconstructionTechnicalQueries = new HashSet<TblSrconstructionTechnicalQueries>();
            TblSrconstructionTechnicalQueriesTemp = new HashSet<TblSrconstructionTechnicalQueriesTemp>();
            TblSrnonConformanceReports = new HashSet<TblSrnonConformanceReports>();
            TblSrnonConformanceReportsTemp = new HashSet<TblSrnonConformanceReportsTemp>();
            TblStaffBioData = new HashSet<TblStaffBioData>();
            TblVendorData = new HashSet<TblVendorData>();
        }

        public int StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public int? CountryId { get; set; }

        public virtual TblCountry Country { get; set; }
        public virtual ICollection<TblCity> TblCity { get; set; }
        public virtual ICollection<TblEndUserRequisitionServices> TblEndUserRequisitionServices { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetails> TblMtoelectricalFormDetails { get; set; }
        public virtual ICollection<TblMtoelectricalFormDetailsTemp> TblMtoelectricalFormDetailsTemp { get; set; }
        public virtual ICollection<TblSrconstructionTechnicalQueries> TblSrconstructionTechnicalQueries { get; set; }
        public virtual ICollection<TblSrconstructionTechnicalQueriesTemp> TblSrconstructionTechnicalQueriesTemp { get; set; }
        public virtual ICollection<TblSrnonConformanceReports> TblSrnonConformanceReports { get; set; }
        public virtual ICollection<TblSrnonConformanceReportsTemp> TblSrnonConformanceReportsTemp { get; set; }
        public virtual ICollection<TblStaffBioData> TblStaffBioData { get; set; }
        public virtual ICollection<TblVendorData> TblVendorData { get; set; }
    }
}
