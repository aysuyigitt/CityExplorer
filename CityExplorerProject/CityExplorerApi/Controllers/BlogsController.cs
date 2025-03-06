using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.BlogMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _blogService; 
        private readonly IMapper _mapper;

        public BlogsController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _blogService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultBlogDto>>(values));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
        {
            var value = _mapper.Map<Blog>(createBlogDto);
            await _blogService.TCreateAsync(value);
            return Ok("Blog alanı eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var value = await _blogService.TGetByIdAsync(id);
            await _blogService.TRemoveAsync(value);
            return Ok("Blog alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            var value = _mapper.Map<Blog>(updateBlogDto);
            await _blogService.TUpdateAsync(value);
            return Ok("Blog alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await _blogService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetBlogDto>(value));

        }
    }

}
