using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Orders
{
    [Table("order", Schema = "buyukbuild")]
    public class Order : AuditableBaseEntity<long>
    {
        [Column("user_id")]
        public long UserId { get; set; }

    }
}
