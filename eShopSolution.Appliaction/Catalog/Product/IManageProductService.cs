using eShopSolution.Appliaction.Catalog.Product.Dtos;
using eShopSolution.Appliaction.Catalog.Product.Dtos.Manage;
using eShopSolution.Appliaction.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Appliaction.Catalog.Product
{
    public interface IManageProductService
    {
        Task<int> create(ProductCreateRequest request);
        Task<int> edit(ProductEditRequest request);
        Task<int> delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addQuantity);

        Task AddViewCount(int productId);

        Task<List<ProductViewModel>> GetAll();

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
