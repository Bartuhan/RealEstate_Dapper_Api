﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Repositories.ProductRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var result = await _productRepository.GetAllProductAsync();
            return Ok(result);
        }

        [HttpGet("GetAllProductWithCategory")]
        public async Task<IActionResult> GetAllProductWithCategory()
        {
            var result = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(result);
        }
    }
}
