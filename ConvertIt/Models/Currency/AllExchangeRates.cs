using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertIt.Models.Currency
{
    public class AllExchangeRates
    {
        public string result { get; set; }
        public string from { get; set; }
        public Dictionary<string,string> rates { get; set; }
    }
}