using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.TestimonialMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var values = await _testimonialService.TGetAllAsync();
            return Ok(_mapper.Map<List<ResultTestimonialDto>>(values));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialDto);
            await _testimonialService.TCreateAsync(value);
            return Ok("Testimonial alanı eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var value = await _testimonialService.TGetByIdAsync(id);
            await _testimonialService.TRemoveAsync(value);
            return Ok("Testimonial alanı silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);
            await _testimonialService.TUpdateAsync(value);
            return Ok("Testimonial alanı güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await _testimonialService.TGetByIdAsync(id);
            return Ok(_mapper.Map<GetTestimonialDto>(value));

        }
    }
}
