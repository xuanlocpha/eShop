﻿using eShopSolution.Appliaction.Catalog.Product;
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

        public ProductController (IPublicProductService publicProductService)
        {
            _publicProductService = publicProductService; 
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var product = await _publicProductService.GetAll();
            return Ok(product);
        }
    }
}
