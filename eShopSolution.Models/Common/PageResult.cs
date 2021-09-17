using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Models.Common
{
    public class PageResult<T> : PagedResultBase
    {
        public List<T> item { get; set; }
    }
}
