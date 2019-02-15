using System.Collections.Generic;

namespace FictionFantasyServer.Models
{
    public class PagedList<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int PageNumber { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
    }
}
