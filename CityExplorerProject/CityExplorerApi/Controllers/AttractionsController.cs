using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.AttractionMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionsController : ControllerBase
    {
        private readonly IAttractionService _attractionService;
        private readonly IMapper _mapper;

        public AttractionsController(IAttractionService attractionService, IMapper mapper)
        {
            _attractionService = attractionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AttractionList()
        {
            var values = await _attractionService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultAttractionDto>>(values));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAttraction(CreateAttractionDto createAttractionDto)
        {
            var value = _mapper.Map<Attraction>(createAttractionDto);
            await _attractionService.TCreateAsync(value);
            return Ok("Gezilecek yerler alanı eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttraction(int id)
        {
            var value = await _attractionService.TGetByIdAsync(id);
            await _attractionService.TRemoveAsync(value);
            return Ok("Gezilecek yerler alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAttraction(UpdateAttractionDto updateAttractionDto)
        {
            var value = _mapper.Map<Attraction>(updateAttractionDto);
            await _attractionService.TUpdateAsync(value);
            return Ok("Gezilecek yerler alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttraction(int id)
        {
            var value = await _attractionService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetAboutDto>(value));

        }
    }
}

