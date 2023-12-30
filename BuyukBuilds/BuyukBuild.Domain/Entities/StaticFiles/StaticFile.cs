using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.StaticFiles
{
    [Table("static_files", Schema = "buyukbuild")]
    public class StaticFile : AuditableBaseEntity<long>
    {
        [Column("path")]
        public string Path { get; set; }
        [Column("url")]
        public string Url { get; set; }
        [Column("size")]
        public long Size { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("file_extension")]
        public string FileExtension { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
