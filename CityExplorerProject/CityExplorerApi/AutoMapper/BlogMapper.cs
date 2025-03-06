using AutoMapper;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.BlogMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class BlogMapper : Profile
    {
        public BlogMapper()
        {
            CreateMap<Blog, ResultBlogDto>().ReverseMap();
            CreateMap<Blog, CreateBlogDto>().ReverseMap();
            CreateMap<Blog, GetBlogDto>().ReverseMap();
            CreateMap<Blog, UpdateBlogDto>().ReverseMap();
        }
    
    }
}
