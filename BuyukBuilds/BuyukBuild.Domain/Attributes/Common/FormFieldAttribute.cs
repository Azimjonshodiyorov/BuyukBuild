using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Attributes.Common
{
    public class FormFieldAttribute :Attribute 
    {
        public string Name { get; set; }
    }
}
