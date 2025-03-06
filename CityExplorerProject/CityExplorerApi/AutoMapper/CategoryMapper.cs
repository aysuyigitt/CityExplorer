using AutoMapper;
using CityExplorer.DtoLayer.AttractionMapper;
using CityExplorer.DtoLayer.CategoryMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class CategoryMapper:Profile
    {
        public CategoryMapper() {

            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
