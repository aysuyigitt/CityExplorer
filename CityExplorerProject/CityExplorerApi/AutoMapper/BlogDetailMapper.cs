using AutoMapper;
using CityExplorer.DtoLayer.AboutMapper;
using CityExplorer.DtoLayer.BlogDetailMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class BlogDetailMapper : Profile
    {
        public BlogDetailMapper()
        {
            CreateMap<BlogDetail, ResultBlogDetailDto>().ReverseMap();
            CreateMap<BlogDetail, CreateBlogDetailDto>().ReverseMap();
            CreateMap<BlogDetail, GetBlogDetailDto>().ReverseMap();
            CreateMap<BlogDetail, UpdateBlogDetailDto>().ReverseMap();
        }

    }
}
