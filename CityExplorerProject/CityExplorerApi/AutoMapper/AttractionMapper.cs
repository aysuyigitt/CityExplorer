using AutoMapper;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.AttractionMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class AttractionMapper:Profile
    {
        public AttractionMapper()
        {
            CreateMap<Attraction, ResultAttractionDto>().ReverseMap();
            CreateMap<Attraction, CreateAttractionDto>().ReverseMap();
            CreateMap<Attraction, GetAttractionDto>().ReverseMap();
            CreateMap<Attraction, UpdateAttractionDto>().ReverseMap();
        }
    }
}
