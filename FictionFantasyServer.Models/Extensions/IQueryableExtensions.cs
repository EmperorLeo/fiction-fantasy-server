using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FictionFantasyServer.Models.Extensions
{
    public static class IQueryableExtensions
    {
        public static async Task<PagedList<T>> ToPagedListAsync<T>(this IQueryable<T> queryable, Filter filter)
        {
            var count = await queryable.CountAsync();
            var items = await queryable.Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

            return new PagedList<T>
            {
                Items = items,
                PageSize = filter.PageSize,
                PageNumber = filter.PageNumber,
                TotalCount = count
            };
        }
    }
}