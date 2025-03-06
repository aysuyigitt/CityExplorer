using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.CityDetailMapper;
using CityExplorer.DtoLayer.CityMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityDetailsController : ControllerBase
    {
        private readonly ICityDetailService _cityDetailService;
        private readonly IMapper _mapper;

        public CityDetailsController(ICityDetailService cityDetailService, IMapper mapper)
        {
            _cityDetailService = cityDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> CityDetailList()
        {
            var values = await _cityDetailService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultCityDetailDto>>(values));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCityDetail(CreateCityDetailDto createCityDetailDto)
        {
            var value = _mapper.Map<CityDetail>(createCityDetailDto);
            await _cityDetailService.TCreateAsync(value);
            return Ok("Şehir detayı alanı eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCityDetail(int id)
        {
            var value = await _cityDetailService.TGetByIdAsync(id);
            await _cityDetailService.TRemoveAsync(value);
            return Ok("Şehir detayı alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCityDetail(UpdateCityDetailDto updateCityDetailDto)
        {
            var value = _mapper.Map<CityDetail>(updateCityDetailDto);
            await _cityDetailService.TUpdateAsync(value);
            return Ok("Şehir detayı alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCityDetail(int id)
        {
            var value = await _cityDetailService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetCityDetailDto>(value));
        }

        [HttpGet("GetCityDetailByCityId")]
        public ActionResult<List<CityDetail>> GetCityDetailByCityId(int id)
        {
            var values = _cityDetailService.TGetCityDetailByCityId(id);
            return Ok(values);
        }
    }
    }

    
