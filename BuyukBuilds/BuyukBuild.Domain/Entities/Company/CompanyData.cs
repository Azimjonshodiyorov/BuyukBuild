using BuyukBuild.Domain.Entities.Address;
using BuyukBuild.Domain.Entities.Cards;
using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Company
{
    [Table("company_data", Schema = "buyukbuild")]
    public class CompanyData : BaseEntity<long>
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("address_id")]
        public long AddresId { get; set; }
        [Column("card_id")]
        public long CardId { get; set; }

        public virtual Card Card { get; set; }
        public virtual AddressData  Address { get; set; }

        public virtual Product      Product { get; set; }
    }
}
