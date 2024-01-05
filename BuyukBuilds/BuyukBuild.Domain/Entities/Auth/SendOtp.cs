using BuyukBuild.Domain.Entities.Auth;
using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Auth
{
    public static class SendOtp
    {
        public static string MakeOtpSmsForPhoneNumber(string otpCode)
        {
            string message = " BuyukBuild " +
                             "Assalomu Aleykum hurmatli mijoz " +
                             "Xafvsizlikni taminlash ucun bu kodni Xech Kimga bermang " +
                             $"sizning tasdiqlash kodingiz:{otpCode}";
            return message;
        }




        public static string MakeHtmlPageShowOtpForEmail(string otpCode)
        {
            string Html =
               "<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n " +
               "   <meta charset=\"UTF-8\">\n   " +
               " <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n " +
               "   <title>Aura ERP Support</title>\n   " +
               " <style>\n      " +
               "body \n{        " +
               " font-family: Arial, sans-serif;\n      " +
               " background-color: #f4f4f4;\n        " +
               "  margin: 0;\n          " +
               "  padding: 0;\n        }\n\n     " +
               "   .container {\n   max-width: 600px;\n            margin: 0 auto;\n            background-color: #ffffff;\n            padding: 20px;\n            border-radius: 5px;\n            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);\n        }\n\n    " +
               "    h1, p {\n            color: #333333;\n        }\n\n      " +
               "  .cta-button {\n            display: inline-block;\n       padding: 10px 20px;\n            background-color: #007bff;\n            color: #ffffff;\n            text-decoration: none;\n            border-radius: 5px;\n        }\n   " +
               $" </style>\n</head>\n<body>\n    <div class=\"container\">\n        <h1>Aura ERP</h1>\n        <p>Assalomu aleykum hurmatli foydalanuvchi!<p>\n         <p>Xafsizlikni ta`mlash ucun bu kodni xich kimga bermang.</p>\n      \n\n        <p>Sizning tasdiqlash kodigiz :{otpCode}</p>\n\n        \n      " +
               "  <a href=\"{---------}\" class=\"cta-button\">Tasdiqlash</a>\n    </div>\n</body>\n</html>";
            return Html;
        }
    }
}



