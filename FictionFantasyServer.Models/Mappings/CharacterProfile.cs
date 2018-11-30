using AutoMapper;
using FictionFantasyServer.Data.Entities;

namespace FictionFantasyServer.Models.Mappings
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<Character, CharacterEntity>().ReverseMap();
        }
    }
}