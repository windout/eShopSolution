using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Models.Common
{
    public class PageResultBase : PagingRequestBase
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