using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPages.Shared.Models
{
    public class Districts
    {
        public List<District> districts { get; set; }
    }
    public class District
    {
        public int district_id { get; set; }
        public string district_name { get; set; }
    }
}
