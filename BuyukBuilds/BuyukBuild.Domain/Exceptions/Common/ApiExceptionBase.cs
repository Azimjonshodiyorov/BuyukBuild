using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Exceptions.Common
{
    public abstract class ApiExceptionBase : Exception
    {
        public virtual int StatusCode { get; set; }

        public ApiExceptionBase(string message)
            : base(message)
        {
        }

        public ApiExceptionBase(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ApiExceptionBase(Exception exception)
            : base(exception.Message, exception)
        {
            StatusCode = 500;
        }
    }
}
