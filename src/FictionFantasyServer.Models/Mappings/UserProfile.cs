using AutoMapper;
using FictionFantasyServer.Data.Entities;

namespace FictionFantasyServer.Models.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserEntity>().ReverseMap();
        }
    }
}
