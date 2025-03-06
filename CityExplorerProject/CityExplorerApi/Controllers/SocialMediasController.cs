using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.SliderMapper;
using CityExplorer.DtoLayer.SocialMediaMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly ISocialMediaService _mediaService;
        private readonly IMapper _mapper;

        public SocialMediasController(ISocialMediaService mediaService, IMapper mapper)
        {
            _mediaService = mediaService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> SocialMediaList()
        {
            var values = await _mediaService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultSocialMediaDto>>(values));
        }
        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            var value = _mapper.Map<SocialMedia>(createSocialMediaDto);
            await _mediaService.TCreateAsync(value);
            return Ok("Sosyal medya alanı eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            var value = await _mediaService.TGetByIdAsync(id);
            await _mediaService.TRemoveAsync(value);
            return Ok("Sosyal medya alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var value = _mapper.Map<SocialMedia>(updateSocialMediaDto);
            await _mediaService.TUpdateAsync(value);
            return Ok("Sosyal medya alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMedia(int id)
        {
            var value = await _mediaService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetSocialMediaDto>(value));

        }

    }
}
