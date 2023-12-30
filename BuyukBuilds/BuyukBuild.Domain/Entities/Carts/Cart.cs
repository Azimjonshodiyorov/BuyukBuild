using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Carts
{
    [Table("cart" , Schema = "buyukbuild")]
    public class Cart : AuditableBaseEntity<long>
    {
        [Column("user_id")]
        public long UserId { get; set; }
        [Column("product_id")]
        public long ProductId { get; set;}
        [Column("active")]
        public bool Active { get; set; }
    }
}
