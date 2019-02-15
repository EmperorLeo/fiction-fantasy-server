using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/[controller]")]
    [ApiController]
    public class NationalitiesController : ControllerBase
    {
        private readonly NationalityService _nationalityService;

        public NationalitiesController(NationalityService nationalityService)
        {
            _nationalityService = nationalityService;
        }

        [HttpGet]
        public Task<Nationality> GetNationality(Guid nationalityId)
        {
            return _nationalityService.GetNationality(nationalityId);
        }
    }
}
