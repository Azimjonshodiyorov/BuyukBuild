using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.DataTransferObjects.StaticFileDto
{
    public record StaticFileDto(
        long id,
        string Url);
}
