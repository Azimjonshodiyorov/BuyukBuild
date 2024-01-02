using BuyukBuild.Domain.Entities.Categories;
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
    public class CategoryRepository : RepositoryBase<Category, long>, ICategoryRepository
    {
        public CategoryRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
