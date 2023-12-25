using BuyukBuild.Domain.Exceptions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Exceptions
{
    public class UnauthorizedException : ApiExceptionBase
    {

        public override int StatusCode { get => 404; }
        public UnauthorizedException(string message)
            : base(message)
        {
        }

        public UnauthorizedException(string message , Exception? innerException) 
            : base(message, innerException) 
        {
        }

        public UnauthorizedException(Exception exception) : base(exception) 
        {
        }

    }
}
