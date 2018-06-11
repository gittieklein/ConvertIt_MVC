using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertIt.Models
{
    public class ConversionModel
    {
        public List<String> CurrencyMeasurements
        {
            get
            {
                return new List<String> { "British Pounds", "Candian Dollars", "Euros", "Israeli Shekels", "US Dollars" };
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