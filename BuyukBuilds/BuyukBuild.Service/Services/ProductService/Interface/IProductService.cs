using BuyukBuild.Domain.DataTransferObjects.Products;
using BuyukBuild.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Service.Services.ProductService.Interface
{
    public interface IProductService
    {
        Task<Product> CreateProductAsync(CreatedProductDto createdProductDto);
        Task<Product> UpdateProductAsync(UpdateProductDto updateProductDto);
        Task<Product> DeleteProductAsync(long id);
        Task<Product?> GetProductByIdAsync(long id);
        Task<IQueryable<Product>> GetProductByNameAsync(string name);

        
    }
}
