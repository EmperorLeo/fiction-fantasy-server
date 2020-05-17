using System.Threading.Tasks;

namespace FictionFantasyServer.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FFDbContext _dbContext;

        public UnitOfWork(FFDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<int> Save()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}