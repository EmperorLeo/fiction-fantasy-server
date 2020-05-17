using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/users")]
    [ApiController]
    [Authorize]
    public class UsersController
    {
        private IUserService _userService;

        [HttpPost]
        public Task<User> CreateUser([FromBody]User user)
        {
            return _userService.CreateUser(user);
        }

        [HttpGet("{userId:guid}")]
        public Task<User> GetUser(Guid userId) {
            return _userService.GetUser(userId);
        }
    }
}