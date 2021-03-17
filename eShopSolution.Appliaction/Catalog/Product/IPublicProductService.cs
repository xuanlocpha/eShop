
using eShopSolution.ViewModels.Catalog.Product;
using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Appliaction.Catalog.Product
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllCategoryId (GetPublicProductPagingRequest request);

    }
}
