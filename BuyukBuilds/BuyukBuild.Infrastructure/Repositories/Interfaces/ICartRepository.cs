using BuyukBuild.Domain.Entities.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Repositories.Interfaces
{
    public interface ICartRepository : IRepositoryBase<Cart , long>
    {
    }
}
