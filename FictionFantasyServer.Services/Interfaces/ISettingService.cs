using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;

namespace FictionFantasyServer.Services.Interfaces
{
    public interface ISettingService
    {
         Task<Setting> GetSetting(Guid settingId);
    }
}