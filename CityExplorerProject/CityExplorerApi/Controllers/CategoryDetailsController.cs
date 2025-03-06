using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.CategoryDetailMapper;
using CityExplorer.DtoLayer.CategoryMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryDetailsController : ControllerBase
    {
        private readonly ICategoryDetailService _categoryDetailService;
        private readonly IMapper _mapper;

        public CategoryDetailsController(ICategoryDetailService categoryDetailService, IMapper mapper)
        {
            _categoryDetailService = categoryDetailService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryDetailList()
        {
            var values = await _categoryDetailService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultCategoryDetailDto>>(values));
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategoryDetail(CreateCategoryDetailDto createCategoryDetailDto)
        {
            var value = _mapper.Map<CategoryDetail>(createCategoryDetailDto);
            await _categoryDetailService.TCreateAsync(value);
            return Ok("Kategori detayı eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryDetail(int id)
        {
            var value = await _categoryDetailService.TGetByIdAsync(id);
            await _categoryDetailService.TRemoveAsync(value);
            return Ok("Kategori detayı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategoryDetail(UpdateCategoryDetailDto updateCategoryDetailDto)
        {
            var value = _mapper.Map<CategoryDetail>(updateCategoryDetailDto);
            await _categoryDetailService.TUpdateAsync(value);
            return Ok("Kategori detayı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryDetail(int id)
        {
            var value = await _categoryDetailService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetCategoryDetailDto>(value));

        }

        [HttpGet("GetCategoryDetailByCityId")]
        public ActionResult<List<CategoryDetail>> GetCategoryDetailByCityId(int id)
        {
            var values =  _categoryDetailService.TGetCategoryDetailByCityId(id);
            return Ok(values);
        }
    }
}