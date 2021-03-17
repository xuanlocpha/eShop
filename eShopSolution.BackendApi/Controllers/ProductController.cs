using eShopSolution.Appliaction.Catalog.Product;
using eShopSolution.ViewModels.Catalog.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductController (IPublicProductService publicProductService,IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        // http ://localhost:port/product 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _publicProductService.GetAll();
            return Ok(products);
        }

        // http ://localhost:port/product/public-paging
        [HttpGet("public-paging")]
        public async Task<IActionResult> Get([FromQuery]GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllCategoryId(request);
            return Ok(products);
        }

        // http ://localhost:port/product/1
        [HttpGet("{id}/{languageId}")]
        public async Task<IActionResult> GetById(int Id, string languageId)
        {
            var products = await _manageProductService.GetById(Id, languageId);
            if (products == null)
                return BadRequest("Cannot find product");
            return Ok(products);
        }


        // http ://localhost:port/product 
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            var productId = await _manageProductService.create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _manageProductService.GetById(productId ,request.LanguageId);

            return CreatedAtAction(nameof(GetById), new {id = productId },product);
        }


        [HttpPut]
        public async Task<IActionResult> Edit([FromForm] ProductEditRequest request)
        {
            var affectedResult = await _manageProductService.edit(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }


        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var affectedResult = await _manageProductService.delete(Id);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }


        [HttpPut("price/{Id}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice([FromQuery] int id, decimal newPrice)
        {
            var isSuccessful = await _manageProductService.UpdatePrice(id,newPrice);
            if (isSuccessful)
                return Ok();
            return BadRequest();
        }

        [HttpPut("price/{Id}/{addQuantity}")]
        public async Task<IActionResult> UpdateStock([FromQuery] int id, int addQuantity)
        {
            var isSuccessful = await _manageProductService.UpdatePrice(id, addQuantity);
            if (isSuccessful)
                return Ok();
            return BadRequest();
        }
        
    }
}
