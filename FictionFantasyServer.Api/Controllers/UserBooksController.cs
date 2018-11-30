using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/users/{userId:guid}/books")]
    [ApiController]
    public class UserBooksController
    {
        private readonly IUserBookService _userBookService;

        public UserBooksController(IUserBookService userBookService)
        {
            _userBookService = userBookService;
        }

        [HttpGet]
        public Task<PagedList<Book>> GetBooks(Guid userId)
        {
            return _userBookService.GetBooks(userId);
        }
    }
}