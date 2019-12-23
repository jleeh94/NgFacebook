using AutoMapper;
using NgFacebook.API.Dtos;
using NgFacebook.API.Models;

namespace NgFacebook.API.Helpers
{
    public class MyMap : Profile
    {
        public MyMap()
        {
            CreateMap<UserForRegisterDto, User>();
            CreateMap<User, UserForDetailedDto>();
        }
    }
}