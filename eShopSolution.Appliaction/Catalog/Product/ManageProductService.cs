using eShopSolution.Appliaction.Catalog.Product.Dtos;
using eShopSolution.Appliaction.Dtos;
using eShopSolution.Data.EF;
using System;
using eShopSolution.Data.Entities;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.Appliaction.Catalog.Product.Dtos.Manage;
using eShopSolution.Utilities.Exceptions;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Appliaction.Catalog.Product
{
    public class ManageProductService : IManageProductService
    {

        private readonly EShopDBContext _context;

        public ManageProductService(EShopDBContext context)
        {
            _context = context;
        }

        public async Task AddViewCount(int productId)
        {
            var product =await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
             await _context.SaveChangesAsync();
        }

        public async Task<int> create(ProductCreateRequest request)
        {
            var product = new eShopSolution.Data.Entities.Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoAlias = request.SeoAlias,
                        SeoTitle = request.SeoTitle,
                        LanguageId = request.LanguageId
                    }
                }
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new EShopException($"Cannot Find A Product : {productId}");
            _context.Products.Remove(product);
          return  await _context.SaveChangesAsync();
        }

        public async Task<int> edit(ProductEditRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            var productTranslations =await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductId == request.Id && x.LanguageId == request.LanguageId);
            if (product == null || productTranslations ==null) throw new EShopException($"Cannot Find A Product With Id : {request.Id}");

            productTranslations.Name = request.Name;
            productTranslations.SeoAlias = request.SeoAlias;
            productTranslations.SeoDescription = request.SeoDescription;
            productTranslations.SeoTitle = request.SeoTitle;
            productTranslations.Description = request.Description;
            productTranslations.Details = request.Details;
            return await _context.SaveChangesAsync();
        }

      

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pt, pic };
            //2. filter
            if (!string.IsNullOrEmpty(request.KeyWord))
                query = query.Where(x => x.pt.Name.Contains(request.KeyWord));

            if (request.CategoryIds.Count > 0)
            {
                query = query.Where(p => request.CategoryIds.Contains(p.pic.CategoryId));
            }


            //3. Paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
               .Take(request.PageSize)
               .Select(x => new ProductViewModel()
               {
                   Id = x.p.Id,
                   Name = x.pt.Name,
                   DateCreated = x.p.DateCreated,
                   Description = x.pt.Description,
                   Details = x.pt.Details,
                   LanguageId = x.pt.LanguageId,
                   OriginalPrice = x.p.OriginalPrice,
                   Price = x.p.Price,
                   SeoAlias = x.pt.SeoAlias,
                   SeoDescription = x.pt.SeoDescription,
                   SeoTitle = x.pt.SeoTitle,
                   Stock = x.p.Stock,
                   ViewCount = x.p.ViewCount
               }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pagedResult;
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null ) throw new EShopException($"Cannot Find A Product With Id : {productId}");
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0; 
        }

        public async Task<bool> UpdateStock(int productId, int addQuantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new EShopException($"Cannot Find A Product With Id : {productId}");
            product.Stock += addQuantity;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
