using System;
using System.Threading.Tasks;
using AutoMapper;
using FictionFantasyServer.Data;
using FictionFantasyServer.Data.Entities;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;

namespace FictionFantasyServer.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserEntity> _userRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _work;

        public UserService(IRepository<UserEntity> userRepository, IMapper mapper, IUnitOfWork work)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _work = work;
        }
 

        public async Task<User> CreateUser(User user)
        {
            UserEntity userEntity = _mapper.Map<UserEntity>(user);
            _userRepository.Add(userEntity);
            
            int result = await _work.Save();
            if (result == 0) {
                throw new Exception("I don't know yet.  User not created.");
            }

            return _mapper.Map<User>(userEntity);
        }

        public async Task<User> GetUser(Guid userId)
        {
            UserEntity entity = await _userRepository.GetById(userId);
            return _mapper.Map<User>(entity);
        }
    }
}