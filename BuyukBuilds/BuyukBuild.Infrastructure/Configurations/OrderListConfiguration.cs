using BuyukBuild.Domain.Entities.OrderLists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Configurations
{
    public class OrderListConfiguration : IEntityTypeConfiguration<OrderList>
    {
        public void Configure(EntityTypeBuilder<OrderList> builder)
        {

            builder
                .HasOne(x => x.Order)
                .WithMany(x => x.OrderLists)
                .HasForeignKey(x => x.OrderId);

        }
    }
}
