using System;
using System.Threading.Tasks;
using AutoMapper;
using FictionFantasyServer.Data;
using FictionFantasyServer.Data.Entities;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;

namespace FictionFantasyServer.Services
{
    public class SpeciesService : ISpeciesService
    {
        private readonly IRepository<SpeciesEntity> _speciesRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _work;

        public SpeciesService(IRepository<SpeciesEntity> speciesRepository, IMapper mapper, IUnitOfWork work)
        {
            _speciesRepository = speciesRepository;
            _mapper = mapper;
            _work = work;
        }
        public async Task<Species> GetSpecies(Guid speciesId)
        {
            return _mapper.Map<Species>(await _speciesRepository.GetById(speciesId));
        }
    }
}
