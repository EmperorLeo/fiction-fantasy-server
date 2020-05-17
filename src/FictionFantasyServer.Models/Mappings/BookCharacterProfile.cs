using AutoMapper;
using FictionFantasyServer.Data.Entities;

namespace FictionFantasyServer.Models.Mappings
{
    public class BookCharacterProfile : Profile
    {
        public BookCharacterProfile()
        {
            CreateMap<BookCharacter, BookCharacterEntity>().ReverseMap();
        }
    }
}
