using BuyukBuild.Domain.DataTransferObjects.Products;
using BuyukBuild.Service.Services.ProductService.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Tar;


namespace BuyukBuild.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService  productService)
        {
            this.productService = productService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddProduct([FromBody] CreatedProductDto productDto)
        {
            var result = await this.productService.CreateProductAsync(productDto);
            return Ok(result);
        }
        [HttpGet("search:{name:string}")]
        public async Task<IActionResult> GetProductByName([FromQuery] string name)
        {
            var result = await this.productService.GetProductByNameAsync(name);
            return Ok(result);
        }
        [HttpGet("id{id:int}")]
        public async Task<IActionResult> GetProductByIdAsync([FromQuery] long id)
        {
            var result = await this.productService.GetProductByIdAsync(id);
            return Ok(result);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProductByIdAsync([FromQuery] long id)
        {
            var result = await this.productService.DeleteProductAsync(id);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductAsync([FromBody] UpdateProductDto updateProductDto)
        {
            var result = await this.productService.UpdateProductAsync(updateProductDto);
            return Ok(result);  
        }
    }
}
