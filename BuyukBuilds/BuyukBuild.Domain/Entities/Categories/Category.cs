using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Categories
{
    [Table("category" , Schema = "buyukbuild")]
    public class Category : AuditableBaseEntity<long>
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("parent_id")]
        public long ParentId { get; set; }
    }
}
