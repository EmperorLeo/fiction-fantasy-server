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
            var items = await queryable.Skip(filter.PageNumber * filter.PageSize).Take(filter.PageSize).ToListAsync();

            return new PagedList<T>
            {
                Items = items,
                PageSize = filter.PageNumber,
                PageNumber = filter.PageNumber,
                TotalCount = count
            };
        }
    }
}