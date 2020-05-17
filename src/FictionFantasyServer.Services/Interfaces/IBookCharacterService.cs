using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;

namespace FictionFantasyServer.Services.Interfaces
{
    public interface IBookCharacterService
    {
         Task UpdateBookCharacter(Guid characterId, BookCharacter bookCharacter);
    
         Task<BookCharacter> GetBookCharacter(Guid bookId, Guid characterId);
    }
}