using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;

namespace FictionFantasyServer.Services.Interfaces
{
    public interface IBookIntroductionService
    {
        Task UpdateBookIntroduction(Guid bookId, Guid bookIntroductionId, string body);

        Task<BookIntroduction> GetBookIntroduction(Guid bookId, Guid bookIntroductionId);
    }
}
