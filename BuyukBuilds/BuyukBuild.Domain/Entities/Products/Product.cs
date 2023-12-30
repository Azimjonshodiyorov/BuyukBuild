using BuyukBuild.Domain.Entities.Carts;
using BuyukBuild.Domain.Entities.Categories;
using BuyukBuild.Domain.Entities.Comments;
using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Entities.Company;
using BuyukBuild.Domain.Entities.Discounts;
using BuyukBuild.Domain.Entities.OrderLists;
using BuyukBuild.Domain.Entities.StaticFiles;
using BuyukBuild.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Products
{
    [Table("product" , Schema = "buyukbuild")]
    public class Product : AuditableBaseEntity<long>
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("price")]
        public decimal Price { get; set; }

        [Column("product_status")]
        public ProductStatus ProductStatus { get; set; }
       
        [Column("company_id")]
        public long CompanyId { get; set; }
        [Column("category_id")]
        public long CategoryId { get; set; }
        [Column("discount_id")]
        public long DiscountId { get; set; }
        [Column("static_file_id")]
        public long StaticFilesId { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OrderList>  OrderLists { get; set; }
        public virtual Discount Discount { get; set; }

        public virtual CompanyData CompanyData { get; set; }

        public virtual Category Category { get; set; }

        public virtual StaticFile StaticFile { get; set; }

    }
}
