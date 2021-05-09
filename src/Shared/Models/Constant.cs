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
        public static string GetDistrictByStateId= "admin/location/districts/{0}";
        public static string APIPostNotofication= "https://prod-15.centralindia.logic.azure.com:443/workflows/e5d4ff0e952a480da2894092200adf04/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=3SbW7vA5OJ-bul3x-eZ-nBatgR8M6vGR1hJR_sniyMo";

        //Alert msg
        public static string AlertMsgNoVaccination = "No Vaccination center is available for booking.";
        public static string AlertMsgNoData = "Please Provide Valid Inputs";
        public static string AlertMsgForbidden = "Setu API Not accessible Outside the India Network.";
        public static string AlertMsgSubscribe = "Notofication Subscribed";

    }
}
