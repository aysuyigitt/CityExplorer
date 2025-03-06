using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.EventDetailMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventDetailsController : ControllerBase
    {
        private readonly IEventDetailService _eventDetailService;
        private readonly IMapper _mapper;

        public EventDetailsController(IEventDetailService eventDetailService, IMapper mapper)
        {
            _eventDetailService = eventDetailService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> EventDetailList()
        {
            var values = await _eventDetailService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultEventDetailDto>>(values));
        }

        [HttpPost]
        public async Task<IActionResult> CreateEventDetail(CreateEventDetailDto createEventDetailDto)
        {
            var value = _mapper.Map<EventDetail>(createEventDetailDto);
            await _eventDetailService.TCreateAsync(value);
            return Ok("Etkinlik detay alanı eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventDetail(int id)
        {
            var value = await _eventDetailService.TGetByIdAsync(id);
            await _eventDetailService.TRemoveAsync(value);
            return Ok("Hakkımda alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEventDetail(UpdateEventDetailDto updateEventDetailDto)
        {
            var value = _mapper.Map<EventDetail>(updateEventDetailDto);
            await _eventDetailService.TUpdateAsync(value);
            return Ok("Etkinlik detay alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventDetail(int id)
        {
            var value = await _eventDetailService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GeEventDetailDto>(value));

        }
        [HttpGet("GetEventDetailByEventId")]
        public ActionResult<List<EventDetail>> GetEventDetailByEventId(int id)
        {
            var values = _eventDetailService.TGetEventDetailByEventId(id);
            return Ok(values);
        }
    }
}
