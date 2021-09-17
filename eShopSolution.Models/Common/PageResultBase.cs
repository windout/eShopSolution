using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Models.Common
{
    public class PagedResultBase : PagingRequestBase
    {
        public int TotalRecords { get; set; }

        public int PageCount
        {
            get
            {
                var pageCount = (double)TotalRecords / PageSize;
                return (int)Math.Ceiling(pageCount);
            }
        }
    }
}