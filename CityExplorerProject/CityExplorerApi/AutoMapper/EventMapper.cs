using AutoMapper;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.EventMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class EventMapper:Profile
    {
        public EventMapper()
        {
            CreateMap<Event, ResultEventDto>().ReverseMap();
            CreateMap<Event, CreateEventDto>().ReverseMap();
            CreateMap<Event, GetEventDto>().ReverseMap();
            CreateMap<Event, UpdateEventDto>().ReverseMap();
        }
    }
}
