using System;
using System.Threading.Tasks;
using FictionFantasyServer.Models;

namespace FictionFantasyServer.Services.Interfaces
{
    public interface IBookService
    {
         Task<Book> GetBook(Guid bookId);
         Task<Book> CreateBook(Guid authorId, Book book);
    }
}