using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services;
using Microsoft.AspNetCore.Mvc;


namespace FictionFantasyServer.Api.Controllers
{
    [Route("api/1.0/books/{bookId:guid}/characters")]
    [ApiController]
    public class BookCharactersController : ControllerBase
    {
        private readonly BookCharacterService _bookCharacterService;

        [HttpGet]
        public Task<BookCharacter> GetBookCharacter(Guid bookId, Guid characterId)
        {
            return _bookCharacterService.GetBookCharacter(bookId, characterId);
        }
        [HttpPut]
        public Task UpdateBookCharacter(Guid characterId, [FromBody]BookCharacter bookCharacter)
        {
            return _bookCharacterService.UpdateBookCharacter(characterId, bookCharacter);
        }

    }


}