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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasMany(x => x.OrderLists)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            builder
                .HasOne(x => x.CompanyData)
                .WithOne(x => x.Product)
                .HasForeignKey<Product>(x => x.CompanyId);
        }
    }
}
