using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Cards
{
    [Table("card" , Schema = "buyukbuild")]
    public class Card : AuditableBaseEntity<long>
    {
        [Column("card_number")]
        public string CardNumber { get; set; }
        [Column("expire_data")]
        public DateTime ExpireData { get; set; }
        [Column("amount")]
        public decimal Amount { get; set; }
    }
}
