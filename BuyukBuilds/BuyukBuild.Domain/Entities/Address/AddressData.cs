using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Entities.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Address
{
    [Table("address_data" , Schema = "buyukbuild")]
    public class AddressData : AuditableBaseEntity<long>
    {
        [Column("city")]
        public string City { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("strength")]
        public string Strength { get; set; }

        public virtual CompanyData CompanyData { get; set; }
    }
}
