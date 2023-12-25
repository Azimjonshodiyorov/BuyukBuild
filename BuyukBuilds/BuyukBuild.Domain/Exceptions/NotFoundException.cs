using BuyukBuild.Domain.Exceptions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Exceptions
{
    public class NotFoundException : ApiExceptionBase
    {
        public NotFoundException(string message) 
            : base(message)
        {
            this.StatusCode = 404;
        }

        public static void ThrowIfNull(object? data , string message = "Not Found")
        {
            if (data is null) 
                throw new NotFoundException(message);
        }
    }
}
