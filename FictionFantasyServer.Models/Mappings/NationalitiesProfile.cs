using AutoMapper;
using FictionFantasyServer.Data.Entities;

namespace FictionFantasyServer.Models.Mappings
{
    public class NationalitiesProfile : Profile
    {
        public NationalitiesProfile()
        {
            CreateMap<Nationality, NationalitiesEntity>().ReverseMap();
        }
    }
}
