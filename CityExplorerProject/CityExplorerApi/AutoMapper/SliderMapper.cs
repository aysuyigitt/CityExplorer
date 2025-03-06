using AutoMapper;
using CityExplorer.DtoLayer.CategoryMapper;
using CityExplorer.DtoLayer.SliderMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class SliderMapper:Profile
    {
        public SliderMapper() {

            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, GetSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
        }
    }
}
