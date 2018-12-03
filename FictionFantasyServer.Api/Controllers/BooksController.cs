using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/books")]
    [ApiController]
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
            return _bookService.CreateBook(Guid.Parse("c7d52279-f39e-4c11-9cab-567821251d65"), book);
        }
    }


}