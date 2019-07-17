using System;
using System.Linq;
using System.Threading.Tasks;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/books")]
    [ApiController]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService) 
        {
            _bookService = bookService;
        }

        [HttpPost]
        public Task<Book> CreateBook([FromBody]Book book)
        {
            return _bookService.CreateBook(Guid.Parse(User.Claims.First(c => c.Type == "sub").Value), book);
        }
    }


}