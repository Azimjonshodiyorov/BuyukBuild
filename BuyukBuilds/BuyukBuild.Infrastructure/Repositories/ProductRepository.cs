using BuyukBuild.Domain.Entities.Products;
using BuyukBuild.Infrastructure.DataContext;
using BuyukBuild.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Repositories
{
    public class ProductRepository : RepositoryBase<Product, long>, IProductRepository
    {
        public ProductRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
