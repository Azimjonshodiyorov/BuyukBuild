using BuyukBuild.Domain.Entities.Auth;
using BuyukBuild.Domain.Entities.Cards;
using BuyukBuild.Domain.Entities.Carts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder
                .HasMany(x => x.Carts)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder
                .HasOne(x => x.Card)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.CardId);

        }
    }
}
