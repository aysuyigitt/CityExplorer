using AutoMapper;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class AboutMapper : Profile
    {
        public AboutMapper()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
