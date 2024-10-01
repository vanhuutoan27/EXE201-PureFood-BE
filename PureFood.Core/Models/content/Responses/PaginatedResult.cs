using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Responses
{
    public class PaginatedResult<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
    }
}