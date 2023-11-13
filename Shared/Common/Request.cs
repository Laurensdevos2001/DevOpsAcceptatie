using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Common
{
    public abstract class Request
    {
        public class Index
        {
            public string? Search { get; set; }
            public int Page { get; set; } = 1;
            public int PageSize { get; set; } = 25;
            public string SortByColumn { get; set; } = "Id";
            public bool SortByAscending { get; set; } = true;
        }
    }
}
