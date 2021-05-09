using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPages.Shared.Models
{
    public class Constant
    {
        //API
        public static string APIBaseUrl = "https://cdn-api.co-vin.in/api/v2/";
        public static string FindByPin = "appointment/sessions/public/findByPin?pincode={0}&date={1}";
        public static string FindByDistrict = "appointment/sessions/public/findByDistrict?district_id={0}&date={1}";
        public static string GetStates= "admin/location/states";
        public static string  GetDistrictByStateId= "admin/location/districts/{0}";

        //Alert msg
        public static string AlertMsgNoVaccination = "No Vaccination center is available for booking.";
        public static string AlertMsgNoData = "Please Provide Valid Inputs";
        public static string AlertMsgForbidden = "Setu API Not accessible Outside the India Network.";

    }
}
