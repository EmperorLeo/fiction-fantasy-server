using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FictionFantasyServer.Data;
using FictionFantasyServer.Data.Entities;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FictionFantasyServer.Services
{
    public class BookCharacterService : IBookCharacterService
    {
        private readonly IRepository<BookCharacterEntity> _bookCharacterRepository;
        private readonly IRepository<BookEntity> _bookRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _work;

        public BookCharacterService(IRepository<BookCharacterEntity> bookCharacterRepository, IRepository<BookEntity> bookRepository, IMapper mapper, IUnitOfWork work)
        {
            _bookCharacterRepository = bookCharacterRepository;
            _bookRepository = bookRepository;
            _mapper = mapper;
            _work = work;
        }

        public Task<BookCharacter> GetBookCharacter(Guid bookId, Guid characterId)
        {
            return _bookCharacterRepository.GetAll()
                .Where(b => b.BookId == bookId)
                .Where(b => b.Id == characterId)
                .ProjectTo<BookCharacter>()
                .FirstOrDefaultAsync();
        }

        public async Task UpdateBookCharacter(Guid bookId, BookCharacter bookCharacter)
        {
            var entity = await _bookRepository.GetAll().Where(b => b.Id == bookId).Select(b => b.BookCharacter) .FirstOrDefaultAsync();
            _mapper.Map(bookCharacter, entity);
            await _work.Save();
        }
    }
}