using System;
using System.Collections.Generic;

namespace JPSAGE_ERP.Domain.Entities
{
    public partial class TblClients
    {
        public TblClients()
        {
            TblEndUserRequisitionProducts = new HashSet<TblEndUserRequisitionProducts>();
            TblEndUserRequisitionServices = new HashSet<TblEndUserRequisitionServices>();
            TblInvoice = new HashSet<TblInvoice>();
            TblMtocivilForm = new HashSet<TblMtocivilForm>();
            TblMtocivilFormTemp = new HashSet<TblMtocivilFormTemp>();
            TblMtoelectricalForm = new HashSet<TblMtoelectricalForm>();
            TblMtoelectricalFormTemp = new HashSet<TblMtoelectricalFormTemp>();
            TblMtoinstrumentForm = new HashSet<TblMtoinstrumentForm>();
            TblMtoinstrumentFormTemp = new HashSet<TblMtoinstrumentFormTemp>();
            TblMtopipingForm = new HashSet<TblMtopipingForm>();
            TblMtopipingFormTemp = new HashSet<TblMtopipingFormTemp>();
            TblQuotationMaster = new HashSet<TblQuotationMaster>();
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte[] ClientLogo { get; set; }
        public string Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string EmailAddress { get; set; }
        public string WebSiteUrl { get; set; }
        public int? CompanyId { get; set; }
        public string ClientCode { get; set; }

        public virtual TblCompanyInfo Company { get; set; }
        public virtual ICollection<TblEndUserRequisitionProducts> TblEndUserRequisitionProducts { get; set; }
        public virtual ICollection<TblEndUserRequisitionServices> TblEndUserRequisitionServices { get; set; }
        public virtual ICollection<TblInvoice> TblInvoice { get; set; }
        public virtual ICollection<TblMtocivilForm> TblMtocivilForm { get; set; }
        public virtual ICollection<TblMtocivilFormTemp> TblMtocivilFormTemp { get; set; }
        public virtual ICollection<TblMtoelectricalForm> TblMtoelectricalForm { get; set; }
        public virtual ICollection<TblMtoelectricalFormTemp> TblMtoelectricalFormTemp { get; set; }
        public virtual ICollection<TblMtoinstrumentForm> TblMtoinstrumentForm { get; set; }
        public virtual ICollection<TblMtoinstrumentFormTemp> TblMtoinstrumentFormTemp { get; set; }
        public virtual ICollection<TblMtopipingForm> TblMtopipingForm { get; set; }
        public virtual ICollection<TblMtopipingFormTemp> TblMtopipingFormTemp { get; set; }
        public virtual ICollection<TblQuotationMaster> TblQuotationMaster { get; set; }
    }
}
