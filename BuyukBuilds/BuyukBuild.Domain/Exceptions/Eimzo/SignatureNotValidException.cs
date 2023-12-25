using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Exceptions.Eimzo
{
    public class SignatureNotValidException : Exception
    {
        public SignatureNotValidException(string? message) 
            : base(message)
        {
        }
    }
}
