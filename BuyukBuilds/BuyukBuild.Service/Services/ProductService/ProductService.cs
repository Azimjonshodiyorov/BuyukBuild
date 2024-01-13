using BuyukBuild.Domain.DataTransferObjects.Products;
using BuyukBuild.Domain.Entities.Auth;
using BuyukBuild.Domain.Entities.Products;
using BuyukBuild.Domain.Exceptions;
using BuyukBuild.Infrastructure.Repositories.Interfaces;
using BuyukBuild.Service.Services.ProductService.Interface;
using BuyukBuild.Service.Validations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Service.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<Product> CreateProductAsync(CreatedProductDto createdProductDto)
        {
           ValidationExceptionIsNull.ValidationIsNullModel(createdProductDto);
            var user = new Product()
            {
                Name = createdProductDto.Name,
                Description = createdProductDto.Description,
                Price = createdProductDto.Price,
                ProductStatus = createdProductDto.ProductStatus,
                DiscountId = createdProductDto.DiscountId,
                StaticFilesId  = createdProductDto.StaticFileId,
                CompanyId = createdProductDto.CompanyId,
                CategoryId = createdProductDto.CategoryId,
            };
            Product product = await this.productRepository.AddAsync(user);
            return product;
        }



        public async Task<Product> DeleteProductAsync(long id)
        {
            ValidationExceptionIsNull.ValidationIsNullById(id);

            var result = await this.productRepository.DeleteAsync(id);
            return result;
        }

        public async Task<Product?> GetProductByIdAsync(long id)
        {
            ValidationExceptionIsNull.ValidationIsNullById(id);

            var result = await this.productRepository.GetByIdAsync(id);
            return result;
        }

        public async Task<IQueryable<Product>> GetProductByNameAsync(string name)
        {
            ValidationExceptionIsNull.ValidationIsNullByName(name);
            var result =  this.productRepository.GetAllAsQueryable()
                .Where(x=> EF.Functions.ILike(x.Name , $"%{name}%"));
            return await Task.FromResult(result);
        }

        public async Task<Product> UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            ValidationExceptionIsNull.ValidationIsNullModel(updateProductDto);

            var product = new Product()
            {
                Name = updateProductDto.Name,
                Description = updateProductDto.Description,
                Price = updateProductDto.Price,
                ProductStatus = updateProductDto.ProductStatus,
                DiscountId = updateProductDto.DiscountId,
                StaticFilesId = updateProductDto.StaticFileId,
                CompanyId = updateProductDto.CompanyId,
                CategoryId = updateProductDto.CategoryId,
            };

            var result = await this.productRepository.UpdateAsync(product);
            return result;
        }
    }
}
