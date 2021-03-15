using AutoMapper;
using ERP.EventBus.Events;
using JPSAGE_ERP.Application.Models;
using JPSAGE_ERP.Domain.Entities;

namespace JPSAGE_ERP.Application.Profiles
{
    public class MaterialTakeOffProfile : Profile
    {
        public MaterialTakeOffProfile()
        {
            CreateMap<MtoDto, TblMtoformsTemp>().ReverseMap();
            CreateMap<MtoPipingDetailsDto, TblMtopipingFormDetailsTemp>().ReverseMap();
            CreateMap<MtoCivilDetailsDto, TblMtocivilFormDetailsTemp>().ReverseMap();
            CreateMap<MtoElectricalDetailsDto, TblMtoelectricalFormDetailsTemp>().ReverseMap();
            CreateMap<MtoInstrumentDetailsDto, TblMtoinstrumentFormDetailsTemp>().ReverseMap();
            
            CreateMap<MtoDisciplineDto, TblMtodiscipline>().ReverseMap();
            CreateMap<MtoSubdisciplineDto, TblMtosubDiscipline>().ReverseMap();

            CreateMap<MtoDto, MaterialTakeOffEvent>().ReverseMap();
            CreateMap<MtoElectricalDetailsDto, MtoElectricalDetailsEvent>().ReverseMap();
            CreateMap<MtoCivilDetailsDto, MtoCivilDetailsEvent>().ReverseMap();
            CreateMap<MtoInstrumentDetailsDto, MtoInstrumentDetailsEvent>().ReverseMap();
            CreateMap<MtoPipingDetailsDto, MtoPipingDetailsEvent>().ReverseMap();
        }
    }
}
