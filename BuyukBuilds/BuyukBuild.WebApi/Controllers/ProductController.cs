using BuyukBuild.Domain.DataTransferObjects.Products;
using BuyukBuild.Service.Services.ProductService.Interface;
using BuyukBuild.WebCore.Models;
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
        public async Task<ResponseModel> AddProduct([FromBody] CreatedProductDto productDto)
        {
            return ResponseModel.ResultFromContent( await this.productService.CreateProductAsync(productDto));
           
        }
        [HttpGet("search:{name:string}")]
        public async Task<ResponseModel> GetProductByName([FromQuery] string name)
        {
             return ResponseModel.ResultFromContent( await this.productService.GetProductByNameAsync(name));
           
        }
        [HttpGet("id{id:int}")]
        public async Task<ResponseModel> GetProductByIdAsync([FromQuery] long id)
        {
            return ResponseModel.ResultFromContent(await this.productService.GetProductByIdAsync(id));
           
        }
        [HttpDelete("{id:int}")]
        public async Task<ResponseModel> DeleteProductByIdAsync([FromQuery] long id)
        {
            return ResponseModel.ResultFromContent( await this.productService.DeleteProductAsync(id));
         
        }
        [HttpPut]
        public async Task<ResponseModel> UpdateProductAsync([FromBody] UpdateProductDto updateProductDto)
        {
            return ResponseModel.ResultFromContent(await this.productService.UpdateProductAsync(updateProductDto));
            
        }
    }
}
