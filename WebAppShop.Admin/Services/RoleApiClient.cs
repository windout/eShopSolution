using eShopSolution.Models.Common;
using eShopSolution.Models.System.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppShop.Admin.Services
{
    public class RoleApiClient : IRoleApiClient
    {
        public Task<ApiResult<List<RoleViewModel>>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
