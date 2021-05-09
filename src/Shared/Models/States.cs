using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPages.Shared.Models
{
    public class State
    {
        public int state_id { get; set; }
        public string state_name { get; set; }
    }

    public class States
    {
        public List<State> states { get; set; }
    }
}
