using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        private readonly SpeciesService _speciesService;

        public SpeciesController(SpeciesService speciesService) 
        {
            _speciesService = speciesService;
        }

        [HttpGet]
        public Task<Species> GetSpecies(Guid speciesId)
        {
            return _speciesService.GetSpecies(speciesId);
        }
    }


}