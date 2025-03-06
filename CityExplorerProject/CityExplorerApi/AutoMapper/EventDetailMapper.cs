using AutoMapper;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.EventDetailMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class EventDetailMapper : Profile
    {
        public EventDetailMapper()
        {
            CreateMap<EventDetail, ResultEventDetailDto>().ReverseMap();
            CreateMap<EventDetail, CreateEventDetailDto>().ReverseMap();
            CreateMap<EventDetail, GeEventDetailDto>().ReverseMap();
            CreateMap<EventDetail, UpdateEventDetailDto>().ReverseMap();
        }
    }
}