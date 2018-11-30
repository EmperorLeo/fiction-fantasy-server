using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FictionFantasyServer.Data;
using FictionFantasyServer.Data.Entities;
using FictionFantasyServer.Models;
using FictionFantasyServer.Models.Extensions;
using FictionFantasyServer.Services.Interfaces;

namespace FictionFantasyServer.Services
{
    public class UserBookService : IUserBookService
    {
        private readonly IRepository<BookEntity> _bookRepository;

        public UserBookService(IRepository<BookEntity> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<PagedList<Book>> GetBooks(Guid userId)
        {
            return _bookRepository.GetAll()
                .Where(b => b.AuthorId == userId)
                .OrderBy(b => b.Title)
                .ProjectTo<Book>()
                .ToPagedListAsync(new Filter());
        }
    }
}