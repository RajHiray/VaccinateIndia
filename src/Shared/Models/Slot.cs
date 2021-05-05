using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPages.Shared.Models
{
    public class Slot
    {
        public List<Session> sessions { get; set; }
    }

    public class Session
    {
        public int center_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string state_name { get; set; }
        public string district_name { get; set; }
        public string block_name { get; set; }
        public int pincode { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public int lat { get; set; }
        public int @long { get; set; }
        public string fee_type { get; set; }
        public string session_id { get; set; }
        public string date { get; set; }
        public int available_capacity { get; set; }
        public string fee { get; set; }
        public int min_age_limit { get; set; }
        public string vaccine { get; set; }
        public List<string> slots { get; set; }
    }
}
