using BuyukBuild.Domain.Entities.Auth;
using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Entities.Company;
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
        [Column("user_id")]
        public long UserId { get; set; }

        public virtual User User { get; set; }
        public virtual CompanyData CompanyData { get; set; }
    }
}
