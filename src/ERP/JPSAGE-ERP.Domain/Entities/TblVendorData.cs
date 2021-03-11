using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblVendorData
    {
        public int VenDataId { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public string AspnetUserId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual AspNetUsers AspnetUser { get; set; }
        public virtual TblCity City { get; set; }
        public virtual TblState State { get; set; }
    }
}
