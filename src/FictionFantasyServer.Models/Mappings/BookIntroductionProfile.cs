using AutoMapper;
using FictionFantasyServer.Data.Entities;

namespace FictionFantasyServer.Models.Mappings
{
    public class BookIntroductionProfile : Profile
    {
        public BookIntroductionProfile() {
            CreateMap<BookIntroduction, BookIntroductionEntity>()
                .ReverseMap();
        }
    }
}