using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertIt.Models
{
    public class EmailInput
    {
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}