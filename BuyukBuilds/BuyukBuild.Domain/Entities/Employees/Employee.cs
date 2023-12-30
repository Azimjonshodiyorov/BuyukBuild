using BuyukBuild.Domain.Entities.Address;
using BuyukBuild.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Employees
{
    [Table("employee", Schema = "buyukbuild")]
    public class Employee : User
    {
        [Column("card_number")]
        public string CardNumber { get; set; }
        [Column("salary")]
        public decimal Salary { get; set; }
        [Column("type")]
        public string Type { get; set; }

        [Column("address_id")]
        public long AddressId { get; set; }
    }
}
