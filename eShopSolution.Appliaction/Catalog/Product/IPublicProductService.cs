using eShopSolution.Appliaction.Catalog.Product.Dtos;
using eShopSolution.Appliaction.Catalog.Product.Dtos.Public;
using eShopSolution.Appliaction.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Appliaction.Catalog.Product
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllCategoryId (GetProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
