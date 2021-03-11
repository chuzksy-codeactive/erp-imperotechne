using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblHseCertificationPerm
    {
        public int HseCertId { get; set; }
        public int SupplierId { get; set; }
        public string NameofCertificate { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string CertificateCopy { get; set; }
        public string CertifyingOrganizationName { get; set; }

        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
