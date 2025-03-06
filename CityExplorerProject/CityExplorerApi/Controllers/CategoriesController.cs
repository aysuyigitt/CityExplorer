using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.AttractionMapper;
using CityExplorer.DtoLayer.CategoryMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]   
        public async Task<IActionResult> CategoryList()
        {
            var values= await _categoryService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultCategoryDto>>(values));
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);   
            await _categoryService.TCreateAsync(value);
            return Ok("Gezilecek yerler alanı eklendi");

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var value = await _categoryService.TGetByIdAsync(id);
            await _categoryService.TRemoveAsync(value);
            return Ok("Gezilecek yerler alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            await _categoryService.TUpdateAsync(value);
            return Ok("Gezilecek yerler alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await   _categoryService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetCategoryDto>(value));

        }
    }
}
