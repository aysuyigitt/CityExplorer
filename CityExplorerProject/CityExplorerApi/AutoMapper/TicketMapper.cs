using AutoMapper;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.TicketMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class TicketMapper : Profile
    {
        public TicketMapper()
        {
            CreateMap<Ticket, ResultTicketDto>().ReverseMap();
            CreateMap<Ticket, CreateTicketDto>().ReverseMap();
            CreateMap<Ticket, GetTicketDto>().ReverseMap();
            CreateMap<Ticket, UpdateTicketDto>().ReverseMap();
        }
    
    }
}
