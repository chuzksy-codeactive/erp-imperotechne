﻿using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblThirdPartyReferencePerm
    {
        public int TprId { get; set; }
        public string TprName { get; set; }
        public string TprOrganization { get; set; }
        public string TprAddress { get; set; }
        public string TprPhoneNumber { get; set; }
        public string TprWorkPhoneNumber { get; set; }
        public string TprEmailAddress { get; set; }
        public int? FormId { get; set; }
        public int? SupplierId { get; set; }
        public string ThirdPartyReference { get; set; }

        public virtual TblFormIdentificationPerm Form { get; set; }
        public virtual TblSupplierIdentificationPerm Supplier { get; set; }
    }
}
