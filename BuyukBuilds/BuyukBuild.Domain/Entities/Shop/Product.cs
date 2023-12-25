using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Shop
{
    [Table("product" , Schema ="shop")]
    public class Product : AuditableBaseEntity<long>
    {

    }
}
