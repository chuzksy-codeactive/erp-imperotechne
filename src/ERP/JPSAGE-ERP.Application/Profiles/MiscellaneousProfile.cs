using AutoMapper;
using JPSAGE_ERP.Application.Models.Miscellaneous;
using JPSAGE_ERP.Domain.Entities;

namespace JPSAGE_ERP.Application.Profiles
{
    public class CountryDtoProfile : Profile
    {
        public CountryDtoProfile()
        {
            CreateMap<TblCountry, CountryDto>();
            CreateMap<TblState, StateDto>();
            CreateMap<TblCity, CityDto>();
            CreateMap<TblStaffBioData, StaffDto>();
            CreateMap<TblSrconstructionTechnicalQueriesTemp, TSrconstructionTechnicalQueriesTempDto>();
            CreateMap<TblSupplierIdentification, SupplierDto>();
            CreateMap<TblCompanyInfo, CompanyInfoDto>().ReverseMap();
            CreateMap<TblClients, ClientDto>();
            CreateMap<TblUnits, UnitDto>();
            CreateMap<TblCurrency, CurrencyDto>();
        }
    }
}
