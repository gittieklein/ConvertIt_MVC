using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertIt.Models
{
    public class ConversionModel
    {
        public List<List<String>> CurrencyMeasurements
        {
            get
            {
                return new List<List<String>> { new List<String> { "Brazilian Reals", "BRL" },
                                                new List<String> { "British Pounds", "GBP" },
                                                new List<String> { "Candian Dollars", "CAD" },
                                                new List<String> { "Chinese Renminbis", "CNY" },
                                                new List<String> { "Euros", "EUR" },
                                                new List<String> { "Indian Rupees", "INR" },
                                                new List<String> { "Israeli Shekels", "ILS" },
                                                new List<String> { "Japanese Yens", "JPY" },
                                                new List<String> { "Mexican Pesos", "MXN" },
                                                new List<String> { "Swiss Francs", "CHF" },
                                                new List<String> { "US Dollars", "USD" } };
            }
        }

        public List<String> LengthMeasurements 
        {
            get
            {
                return new List<String> { "Centimeters", "Feet", "Inches", "Kilometers", "Meters", "Miles", "Millimeters", "Yards" };
            }
        }

        public List<String> TemperatureMeasurements
        {
            get
            {
                return new List<String> { "Celcius", "Farenheit", "Kelvin" };
            }
        }

        public List<String> TimeMeasurements
        {
            get
            {
                return new List<String> { "Days", "Hours", "Minutes", "Seconds" };
            }
        }

        public List<String> WeightMeasurements
        {
            get
            {
                return new List<String> { "Grams", "Kilograms", "Ounces", "Pounds", "Tons" };
            }
        }
    }
}