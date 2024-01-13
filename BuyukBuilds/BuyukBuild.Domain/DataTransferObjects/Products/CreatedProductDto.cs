﻿using BuyukBuild.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.DataTransferObjects.Products
{
    public record CreatedProductDto(
        string Name,
        string Description,
        decimal Price,
        ProductStatus ProductStatus,
        long CompanyId,
        long CategoryId,
        long DiscountId,
        long StaticFileId);
}
