using AutoMapper;
using Cache.API.Entities;
using Cache.API.Model;
using ERP.EventBus.Events;

namespace Cache.API.Mapper
{
    public class MaterialTakeOffMapping : Profile
    {
        public MaterialTakeOffMapping()
        {
            CreateMap<MaterialTakeOffDto, MaterialTakeOff>().ReverseMap();
            CreateMap<MaterialTakeOffDto, MaterialTakeOffEvent>().ReverseMap();

            // Mapping the MTO details DTOs to their respective entities
            CreateMap<MtoElectricalDetailsDto, MtoElectricalDetails>().ReverseMap();
            CreateMap<MtoPipingDetailsDto, MtoPipingDetails>().ReverseMap();
            CreateMap<MtoInstrumentDetailsDto, MtoInstrumentDetails>().ReverseMap();
            CreateMap<MtoCivilDetailsDto, MtoCivilDetails>().ReverseMap();

            // Mapping the MTO details DTOs to their respective event models
            CreateMap<MtoCivilDetailsDto, MtoCivilDetailsEvent>().ReverseMap();
            CreateMap<MtoElectricalDetailsDto, MtoElectricalDetailsEvent>().ReverseMap();
            CreateMap<MtoPipingDetailsDto, MtoPipingDetailsEvent>().ReverseMap();
            CreateMap<MtoInstrumentDetailsDto, MtoInstrumentDetailsEvent>().ReverseMap();
        }
    }
}
