using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;

namespace FictionFantasyServer.Services.Interfaces
{
    public interface ISpeciesService
    {
         Task<Species> GetSpecies(Guid speciesId);
    }
}
