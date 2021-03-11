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
            CreateMap<MaterialTakeOffDetailDto, MaterialTakeOffDetail>().ReverseMap();
            CreateMap<MaterialTakeOffDto, MaterialTakeOffEvent>().ReverseMap();
        }
    }
}
