using BuyukBuild.Domain.Entities.Auth;
using BuyukBuild.Domain.Entities.Cards;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Configurations
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {

            builder
                .HasOne(x => x.User)
                .WithOne(x => x.Card)
                .HasForeignKey<User>(x => x.CardId);
        }
    }
}
