using BuyukBuild.Domain.Entities.Discounts;
using BuyukBuild.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Configurations
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder
                .HasOne(x => x.Product)
                .WithOne(x => x.Discount)
                .HasForeignKey<Product>(x => x.DiscountId);
        }
    }
}
