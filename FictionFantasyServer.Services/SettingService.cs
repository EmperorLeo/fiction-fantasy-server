using System;
using System.Threading.Tasks;
using AutoMapper;
using FictionFantasyServer.Data;
using FictionFantasyServer.Data.Entities;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;

namespace FictionFantasyServer.Services
{
    public class SettingService : ISettingService
    {
        private readonly IRepository<SettingsEntity> _settingRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _work;

        public SettingService(IRepository<SettingsEntity> settingRepository, IMapper mapper, IUnitOfWork work)
        {
            _settingRepository = settingRepository;
            _mapper = mapper;
            _work = work;
        }
        public async Task<Setting> GetSetting(Guid settingId)
        {
            return _mapper.Map<Setting>(await _settingRepository.GetById(settingId));
        }
    }
}
