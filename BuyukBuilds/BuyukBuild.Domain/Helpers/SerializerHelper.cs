using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Helpers
{
    public static class SerializerHelper
    {
        public static string ToJsonString(object data)
        {
            return JsonSerializer.Serialize(data);
        }

        public static  T FromJsonString<T>(string content)
        {
            return JsonSerializer.Deserialize<T>(content);
        }
       
    }
}
