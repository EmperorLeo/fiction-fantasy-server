using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/books/{bookId:guid}/introduction")]
    [ApiController]
    public class BooksIntroductionController : ControllerBase
    {
        private readonly BookIntroductionService _bookIntroductionService;

        public BooksIntroductionController(BookIntroductionService bookIntroductionService) 
        {
            _bookIntroductionService = bookIntroductionService;
        }

        [HttpPut]
        public Task UpdateIntroduction(Guid bookId, [FromBody]BookIntroduction bookIntroduction)
        {
            return _bookIntroductionService.UpdateBookIntroduction(bookId, bookIntroduction);
        }
    }


}