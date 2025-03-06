using AutoMapper;
using CityExplorer.DtoLayer.AttractionMapper;
using CityExplorer.DtoLayer.CategoryDetailMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class CategoryDetailMapper:Profile
    {
        public CategoryDetailMapper() {

            CreateMap<CategoryDetail, ResultCategoryDetailDto>().ReverseMap();
            CreateMap<CategoryDetail, CreateCategoryDetailDto>().ReverseMap();
            CreateMap<CategoryDetail, GetCategoryDetailDto>().ReverseMap();
            CreateMap<CategoryDetail, UpdateCategoryDetailDto>().ReverseMap();

        }
    }
}
