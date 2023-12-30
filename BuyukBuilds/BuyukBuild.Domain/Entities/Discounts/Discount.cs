using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Discounts
{
    [Table("discount", Schema = "buyukbuild")]
    public class Discount : AuditableBaseEntity<long>
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("procent")]
        public double Procent { get; set; }

    }
}
