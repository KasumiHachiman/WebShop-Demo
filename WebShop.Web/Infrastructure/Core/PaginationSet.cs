using System.Collections.Generic;
using System.Linq;

namespace WebShop.Web.Infrastructure.Core
{
    public class PaginationSet<T>
    {
        public int Page { get; set; }
        public int PageCount { get { return Items != null ? Items.Count() : 0; } }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public ICollection<T> Items { get; set; }
    }
}