using AutoMapper;
using FictionFantasyServer.Data.Entities;

namespace FictionFantasyServer.Models.Mappings
{
    public class SettingsProfile : Profile
    {
        public SettingsProfile()
        {
            CreateMap<Setting, SettingsEntity>().ReverseMap();
        }
    }
}