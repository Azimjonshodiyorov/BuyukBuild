using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Exceptions
{
    public class ExpiredException : Exception
    {
        public ExpiredException(string message, Exception? innerException = null) 
            : base(message, innerException)
        {
        }
    }
}
