﻿using GeekShoppingProduct.Data.ValueObjects;
using GeekShoppingProduct.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShoppingProduct.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> FindAll(long id)
        {
            var products = await _productRepository.FindAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> FindById(long id)
        {
            var product = await _productRepository.FindById(id);
            if (product.Id <= 0) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> Create(ProductDto dto)
        {
            if (dto == null) return BadRequest();
            var product = await _productRepository.Create(dto);
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<ProductDto>> Update(ProductDto dto)
        {
            if (dto == null) return BadRequest();
            var product = await _productRepository.Update(dto);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var product = await _productRepository.Delete(id);
            if (!product) return BadRequest();
            return Ok(product);
        }
    }
}
