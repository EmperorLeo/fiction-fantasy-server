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
    public class BookIntroductionService : IBookIntroductionService
    {
        private readonly IRepository<BookIntroductionEntity> _bookIntroductionRepository;
        private readonly IRepository<BookEntity> _bookRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _work;

        public BookIntroductionService(IRepository<BookIntroductionEntity> bookIntroductionRepository, IRepository<BookEntity> bookRepository, IMapper mapper, IUnitOfWork work)
        {
            _bookIntroductionRepository = bookIntroductionRepository;
            _bookRepository = bookRepository;
            _mapper = mapper;
            _work = work;
        }

        public async Task UpdateBookIntroduction(Guid bookId, string body)
        {
            var entity = await _bookRepository.GetAll().Where(b => b.Id == bookId).Select(b => b.BookIntroduction).FirstOrDefaultAsync();
            _mapper.Map(b.BookIntroduction, entity);
            
            // saves body text into BookIntroduction summary
            entity.Summary = body;
            await _work.Save();
        }

        public Task<BookIntroduction> GetBookIntroduction(Guid bookId)
        {
            return _bookRepository.GetAll()
                .Where(b => b.Id == bookId)
                .Select(b => b.BookIntroduction)
                .ProjectTo<BookIntroduction>()
                .FirstOrDefaultAsync();

        }
    }
}