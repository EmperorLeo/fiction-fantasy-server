using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;

namespace FictionFantasyServer.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUser(User user);
        Task<User> GetUser(Guid userId);
    }
}