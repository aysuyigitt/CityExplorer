using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutsController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _aboutService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultAboutDto>>(values));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
        {
            var value = _mapper.Map<About>(createAboutDto);
            await _aboutService.TCreateAsync(value);
            return Ok("Hakkımda alanı eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            var value = await _aboutService.TGetByIdAsync(id);
            await _aboutService.TRemoveAsync(value);
            return Ok("Hakkımda alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            await _aboutService.TUpdateAsync(value);
            return Ok("Hakkımda alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = await _aboutService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetAboutDto>(value));

        }
        }
        }
