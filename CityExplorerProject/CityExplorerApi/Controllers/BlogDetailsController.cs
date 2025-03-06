using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.BlogDetailMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogDetailsController : ControllerBase
    {
        private readonly IBlogDetailService _blogDetailService;
        private readonly IMapper _mapper;

        public BlogDetailsController(IBlogDetailService blogDetailService, IMapper mapper)
        {
            _blogDetailService = blogDetailService;
           _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> BlogDetailList()
        {
            var values = await _blogDetailService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultBlogDetailDto>>(values));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlogDetail(CreateBlogDetailDto createBlogDetailDto)
        {
            var value = _mapper.Map<BlogDetail>(createBlogDetailDto);
            await _blogDetailService.TCreateAsync(value);
            return Ok("Blog detay alanı eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogDetail(int id)
        {
            var value = await _blogDetailService.TGetByIdAsync(id);
            await _blogDetailService.TRemoveAsync(value);
            return Ok("Blog detay alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlogDetail(UpdateBlogDetailDto updateBlogDetailDto)
        {
            var value = _mapper.Map<BlogDetail>(updateBlogDetailDto);
            await _blogDetailService.TUpdateAsync(value);
            return Ok("Blog detay alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogDetail(int id)
        {
            var value = await _blogDetailService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetBlogDetailDto>(value));

        }

        [HttpGet("GetBlogDetailByBlogId")]
        public ActionResult<List<BlogDetail>> GetBlogDetailByBlogId(int id)
        {
            var values = _blogDetailService.TGetBlogDetailByBlogId(id);
            return Ok(values);
        }
    }




}
