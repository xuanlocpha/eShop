using eShopSolution.Appliaction.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Appliaction.Catalog.Product.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
