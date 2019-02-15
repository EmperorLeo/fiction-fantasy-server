using System;
using System.Threading.Tasks;
using AutoMapper;
using FictionFantasyServer.Data;
using FictionFantasyServer.Data.Entities;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;

namespace FictionFantasyServer.Services
{
    public class NationalityService : INationalityService
    {
        private readonly IRepository<NationalitiesEntity> _nationalityRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _work;

        public NationalityService(IRepository<NationalitiesEntity> nationalityRepository, IMapper mapper, IUnitOfWork work)
        {
            _nationalityRepository = nationalityRepository;
            _mapper = mapper;
            _work = work;
        }
        public async Task<Nationality> GetNationality(Guid nationalityId)
        {
            return _mapper.Map<Nationality>(await _nationalityRepository.GetById(nationalityId));
        }
    }
}