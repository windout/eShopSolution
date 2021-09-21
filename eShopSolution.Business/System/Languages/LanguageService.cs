using eShopSolution.Data.EF;
using eShopSolution.Models.Common;
using eShopSolution.Models.System.Language;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Business.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly eShoppingDbContext _context;

        public LanguageService(eShoppingDbContext context)
        {          
            _context = context;
        }

        public async Task<ApiResult<List<LanguageViewModel>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                IsDefault = x.IsDefault
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageViewModel>>(languages);
        }
    }
}
