﻿using BuyukBuild.Domain.Entities.Auth;
using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Comments
{
    [Table("comment" , Schema = "buyukbuild")]
    public class Comment : AuditableBaseEntity<long>
    {
        [Column("user_id")]
        public long UserId { get; set; }
        [Column("product_id")]
        public long ProductId { get; set; }
        [Column("text")]
        public string Text { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }

    }
}
