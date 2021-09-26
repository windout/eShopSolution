using eShopSolution.Models.Common;
using eShopSolution.Models.System.Language;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAppShop.Admin.Services
{
    public class LanguageApiClient : BaseApiClient, ILanguageApiClient
    {
        public LanguageApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        : base(httpClientFactory, httpContextAccessor)
        {
        }

        public async Task<ApiResult<List<LanguageViewModel>>> GetAll()
        {
            return await GetAsync<ApiResult<List<LanguageViewModel>>>("/api/languages");
        }
    }
}
