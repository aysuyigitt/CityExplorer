using AutoMapper;
using CityExplorer.DtoLayer.AttractionMapper;
using CityExplorer.DtoLayer.CityDetailMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class CityDetailMapper : Profile
    {
        public CityDetailMapper()
        {
            CreateMap<CityDetail, ResultCityDetailDto>().ReverseMap();
            CreateMap<CityDetail, CreateCityDetailDto>().ReverseMap();
            CreateMap<CityDetail, GetCityDetailDto>().ReverseMap();
            CreateMap<CityDetail, UpdateCityDetailDto>().ReverseMap();
        }
    }
}
