using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;

namespace FictionFantasyServer.Services.Interfaces
{
    public interface INationalityService
    {
         Task<Nationality> GetNationality(Guid nationalityId);
    }
}
