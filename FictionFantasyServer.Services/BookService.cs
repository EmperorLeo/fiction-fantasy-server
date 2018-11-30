using System;
using System.Threading.Tasks;
using AutoMapper;
using FictionFantasyServer.Data;
using FictionFantasyServer.Data.Entities;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;

namespace FictionFantasyServer.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<BookEntity> _bookRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _work;

        public BookService(IRepository<BookEntity> bookRepository, IMapper mapper, IUnitOfWork work)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _work = work;
        }

        public async Task<Book> CreateBook(Guid authorId, Book book)
        {
            book.AuthorId = authorId;
            var entity = _mapper.Map<BookEntity>(book);
            _bookRepository.Add(entity);
            await _work.Save();
            return _mapper.Map(entity, book);
        }

        public async Task<Book> GetBook(Guid bookId)
        {
            return _mapper.Map<Book>(await _bookRepository.GetById(bookId));
        }
    }
}