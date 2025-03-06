using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.EventMapper;
using CityExplorer.DtoLayer.SliderMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SlidersController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> SliderList()
        {
            var values = await _sliderService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultSliderDto>>(values));
        }
        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            var value = _mapper.Map<Slider>(createSliderDto);
            await _sliderService.TCreateAsync(value);
            return Ok("Slider alanı eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSlider(int id)
        {
            var value = await _sliderService.TGetByIdAsync(id);
            await _sliderService.TRemoveAsync(value);
            return Ok("Slider alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            var value = _mapper.Map<Slider>(updateSliderDto);
            await _sliderService.TUpdateAsync(value);
            return Ok("Slider alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSlider(int id)
        {
            var value = await _sliderService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetSliderDto>(value));

        }
    }
}
