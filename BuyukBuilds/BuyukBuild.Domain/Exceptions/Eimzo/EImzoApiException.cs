using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Exceptions.Eimzo
{
    public class EImzoApiException : Exception
    {
        public EImzoApiException(string? message) : base(message)
        {
        }
    }
}
