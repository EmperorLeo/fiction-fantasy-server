using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public UserBookService(IRepository<BookEntity> bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public Task<PagedList<Book>> GetBooks(Guid userId)
        {
            return _mapper.ProjectTo<Book>(_bookRepository.GetAll()
                    .Where(b => b.AuthorId == userId)
                    .OrderBy(b => b.Title))
                .ToPagedListAsync(new Filter());
        }
    }
}