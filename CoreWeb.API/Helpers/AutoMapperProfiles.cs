using AutoMapper;
using CoreWeb.API.Dtos;
using CoreWeb.API.Models;

namespace CoreWeb.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailedDto>();
        }
    }
}