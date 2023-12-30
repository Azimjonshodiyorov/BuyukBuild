using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Entities.Orders;
using BuyukBuild.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.OrderLists
{
    [Table("order_list", Schema = "buyukbuild")]
    public class OrderList : AuditableBaseEntity<long>
    {
        [Column("order_id")]
        public long OrderId { get; set; }
        [Column("product_id")]
        public long ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
