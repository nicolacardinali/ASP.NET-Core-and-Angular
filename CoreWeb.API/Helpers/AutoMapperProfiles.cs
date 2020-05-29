using System.Linq;
using AutoMapper;
using CoreWeb.API.Dtos;
using CoreWeb.API.Models;

namespace CoreWeb.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(
                    dest => dest.PhotoUrl,
                    opt => opt.MapFrom(
                        src => src.Photos.FirstOrDefault(p => p.IsMain).Url
                        ));
            CreateMap<User, UserForDetailedDto>()
                .ForMember(
                    dest => dest.PhotoUrl,
                    opt => opt.MapFrom(
                        src => src.Photos.FirstOrDefault(p => p.IsMain).Url
                        ));
            CreateMap<Photo, PhotosForDetailedDto>();
        }
    }
}