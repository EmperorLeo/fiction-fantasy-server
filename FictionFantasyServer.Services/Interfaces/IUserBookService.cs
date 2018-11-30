using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;

namespace FictionFantasyServer.Services.Interfaces
{
    public interface IUserBookService
    {
        Task<PagedList<Book>> GetBooks(Guid userId);
    }
}