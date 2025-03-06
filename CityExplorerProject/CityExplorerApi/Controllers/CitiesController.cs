using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.CityMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public CitiesController(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> CityList()
        {
            var values = await _cityService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultCityDto>>(values));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCity(CreateCityDto createCityDto)
        {
            var value = _mapper.Map<City>(createCityDto);
            await _cityService.TCreateAsync(value);
            return Ok("Şehir alanı eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var value = await _cityService.TGetByIdAsync(id);
            await _cityService.TRemoveAsync(value);
            return Ok("Şehir alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCity(UpdateCityDto updateCityDto)
        {
            var value = _mapper.Map<City>(updateCityDto);
            await _cityService.TUpdateAsync(value);
            return Ok("Şehir alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCity(int id)
        {
            var value = await _cityService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetCityDto>(value));

        }
    }
}
