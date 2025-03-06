using AutoMapper;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.CityMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class CityMapper:Profile
    {
        public CityMapper() {

            CreateMap<City, ResultCityDto>().ReverseMap();
            CreateMap<City, CreateCityDto>().ReverseMap();
            CreateMap<City, GetCityDto>().ReverseMap();
            CreateMap<City, UpdateCityDto>().ReverseMap();
        }
    }
}
