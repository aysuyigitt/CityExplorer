using AutoMapper;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.TestimonialMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class TestimonialMapper:Profile
    {
        public TestimonialMapper()
        {
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
