using System.Threading.Tasks;

namespace FictionFantasyServer.Data
{
    public interface IUnitOfWork
    {
         Task<int> Save();
    }
}