using eShopSolution.Models.Common;
using eShopSolution.Models.System.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppShop.Admin.Services
{
    public class LanguageApiClient : ILanguageApiClient
    {
        public Task<ApiResult<List<LanguageViewModel>>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
