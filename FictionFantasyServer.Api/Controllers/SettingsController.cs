using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly SettingService _settingService;

        public SettingsController(SettingService settingService) 
        {
            _settingService = settingService;
        }

        [HttpGet]
        public Task<Setting> GetSetting(Guid settingId)
        {
            return _settingService.GetSetting(settingId);
        }
    }


}
