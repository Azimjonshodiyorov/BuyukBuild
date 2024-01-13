using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Service.Validations
{
    public static class ValidationExceptionIsNull
    {
        public static void ValidationIsNullModel<T>(T value) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException("Null data Come");
            }
            var propertys = nameof(T).GetType().GetProperties();

            foreach (var property in propertys)
            {
                if (property is null)
                {
                    throw new Exception("Property is null");
                }
            }
        }

        public static void ValidationIsNullById(long id)
        {
            if (id == 0)
            {
                throw new Exception("id Null come");
            }
        }


        public static void ValidationIsNullByName(string name)
        {
            if(name == null)
            { throw new Exception("Name null come"); }
        }
    }
}
