using eShopSolution.Data.EF;
using eShopSolution.Data.entities;
using eShopSolution.Models.Catalog.Products;
using eShopSolution.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Business.Catalog.Products
{
    public class ProductService : IProductService
    {
        private readonly eShoppingDbContext _context;

        public ProductService(eShoppingDbContext context) => _context = context;

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {

            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<ProductViewModel>> GetAll_Paging(GetManageProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetAll_ProductVM()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            throw new NotImplementedException();
        }
    }
}
