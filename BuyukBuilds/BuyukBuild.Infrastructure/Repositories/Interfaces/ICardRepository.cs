using BuyukBuild.Domain.Entities.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Repositories.Interfaces
{
    public interface ICardRepository : IRepositoryBase<Card , long>
    {
    }
}
