

using eShopSolution.ViewModels.Catalog.Product;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
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

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImages(int productId, List<IFormFile> files);
      
        Task<int> RemoveImages(int productId);
        
        Task<int> EditImages(int productId ,string caption , bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
