using AutoMapper;
using Cache.API.Entities;
using Cache.API.Model;

namespace Cache.API.Mapper
{
    public class MaterialTakeOffMapping : Profile
    {
        public MaterialTakeOffMapping()
        {
            CreateMap<MaterialTakeOffDto, MaterialTakeOff>().ReverseMap();
            CreateMap<MaterialTakeOffDetailDto, MaterialTakeOffDetail>().ReverseMap();
        }
    }
}
