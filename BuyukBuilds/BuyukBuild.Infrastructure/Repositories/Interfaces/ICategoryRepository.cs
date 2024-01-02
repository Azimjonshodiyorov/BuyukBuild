using BuyukBuild.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepositoryBase<Category , long>
    {
    }
}
