using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;

namespace FictionFantasyServer.Services.Interfaces
{
    public interface IBookIntroductionService
    {
        Task UpdateBookIntroduction(Guid bookId, BookIntroduction bookIntroduction);

        Task<BookIntroduction> GetBookIntroduction(Guid bookId);
    }
}
