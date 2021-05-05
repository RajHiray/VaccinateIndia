using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPages.Shared.Models
{
    public class Constant
    {
        public static string APIBaseUrl = "https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/";
        public static string findByPin = "findByPin?pincode={0}&date={1}";
    }
}
