using AutoMapper;
using CityExplorer.DtoLayer.SocialMediaMapper;
using CityExplorer.EntitiesLayer.Entities;

namespace CityExplorerApi.AutoMapper
{
    public class SocialMediaMapper : Profile
    {
        public SocialMediaMapper(){

        CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
    }
    }
}
