namespace JPSAGE_ERP.Application.Models.Miscellaneous
{
    public class CountryDto
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }

    public class StateDto
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }

    public class CityDto
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }

    public class StaffDto
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class SupplierDto
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
    }

    public class TSrconstructionTechnicalQueriesTempDto
    {
        public int Ctqid { get; set; }
        public string Ctqtitle { get; set; }
    }

    public class CompanyInfoDto
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }

    public class ClientDto
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
    }

    public class UnitDto
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
    }

    public class CurrencyDto
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
    }
}
