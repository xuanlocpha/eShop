using eShopSolution.Appliaction.Catalog.Product.Dtos;
using eShopSolution.Appliaction.Catalog.Product.Dtos.Manage;
using eShopSolution.Appliaction.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Appliaction.Catalog.Product
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllCategoryId (GetProductPagingRequest request);
    }
}
