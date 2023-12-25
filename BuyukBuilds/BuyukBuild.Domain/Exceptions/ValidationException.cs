using BuyukBuild.Domain.Exceptions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Exceptions
{
    public class ValidationException : ApiExceptionBase
    {
        public ValidationException(string message) 
            : base(message)
        {
            this.StatusCode = 400;
        }
    }
}
