using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.CategoryMapper;
using CityExplorer.DtoLayer.EventMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;

        public EventsController(IEventService eventService, IMapper mapper)
        {
            _eventService = eventService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> EventList()
        {
            var values = await _eventService.TGetAllAsync();   
            return Ok(_mapper.Map<List<ResultEventDto>>(values));   
        }
        [HttpPost]  
        public async Task<IActionResult> CreateEvent(CreateEventDto createEventDto)
        {
           var value = _mapper.Map<Event>(createEventDto); 
            await _eventService.TCreateAsync(value);
            return Ok("Etkinlik alanı eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var value = await _eventService.TGetByIdAsync(id);
            await _eventService.TRemoveAsync(value);
            return Ok("Etkinlik alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEvent(UpdateEventDto updateEventDto)
        {
            var value = _mapper.Map<Event>(updateEventDto);
            await _eventService.TUpdateAsync(value);
            return Ok("Etkinlik alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent(int id)
        {
            var value = await _eventService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetEventDto>(value));

        }
    }
}
