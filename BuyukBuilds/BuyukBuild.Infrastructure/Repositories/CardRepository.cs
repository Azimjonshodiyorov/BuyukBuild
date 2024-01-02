using BuyukBuild.Domain.Entities.Cards;
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
    public class CardRepository : RepositoryBase<Card, long>, ICardRepository
    {
        public CardRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
