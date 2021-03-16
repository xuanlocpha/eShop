using eShopSolution.Appliaction.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Appliaction.Catalog.Product.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
