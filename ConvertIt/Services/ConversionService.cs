using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertIt.Services
{
    public class ConversionService
    {
        #region Length   
        public double GetLength(int input, string from, string to)
        {
            if(string.Equals(from, to, StringComparison.OrdinalIgnoreCase))
                return input;

            switch(from)
            {
                case "Centimeters":
                    return LengthFromCentimeters(input, to);
                case "Feet":
                    return LengthFromFeet(input, to);
                case "Inches":
                    return LengthFromInches(input, to);
                case "Kilometers":
                    return LengthFromKilometers(input, to);
                case "Meters":
                    return LengthFromMeters(input, to);
                case "Miles":
                    return LengthFromMiles(input, to);
                case "Millimeters":
                    return LengthFromMillimeters(input, to);
                case "Yards":
                    return LengthFromYards(input, to);
            }
            return 0;
        }       

        private double LengthFromCentimeters(int input, string to)
        {
            switch (to)
            {
                case "Feet":
                    return (double)input * 0.0328084;
                case "Inches":
                    return (double)input * 0.393701;
                case "Kilometers":
                    return (double)input * 0.00001;
                case "Meters":
                    return (double)input * 0.01;
                case "Miles":
                    return (double)input * 0.00000621;
                case "Millimeters":
                    return (double)input * 10;
                case "Yards":
                    return (double)input * 0.0109361;
                default:
                    return 0;
            }
        }

        public double LengthFromFeet(int input, string to)
        {
            switch (to)
            {
                case "Centimeters":
                    return (double)input * 30.48;
                case "Inches":
                    return (double)input * 12;
                case "Kilometers":
                    return (double)input * 0.0003048;
                case "Meters":
                    return (double)input * 0.3048;
                case "Miles":
                    return (double)input * 0.000189394;
                case "Millimeters":
                    return (double)input * 304.8;
                case "Yards":
                    return (double)input / 3;
                default:
                    return 0;
            }
        }

        private double LengthFromInches(int input, string to)
        {
            switch (to)
            {
                case "Centimeters":
                    return (double)input * 2.54;
                case "Feet":
                    return (double)input / 12;
                case "Kilometers":
                    return (double)input * 0.0000254;
                case "Meters":
                    return (double)input * 0.0254;
                case "Miles":
                    return (double)input * 0.00001578;
                case "Millimeters":
                    return (double)input / 25.4;
                case "Yards":
                    return (double)input / 36;
                default:
                    return 0;
            }
        }

        private double LengthFromKilometers(int input, string to)
        {
            switch (to)
            {
                case "Centimeters":
                    return (double)input * 100000;
                case "Feet":
                    return (double)input * 3280.84;
                case "Inches":
                    return (double)input * 39370.08;
                case "Meters":
                    return (double)input * 1000;
                case "Miles":
                    return (double)input * 0.621371;
                case "Millimeters":
                    return (double)input * 1000000;
                case "Yards":
                    return (double)input * 1093.61;
                default:
                    return 0;
            }
        }

        private double LengthFromMeters(int input, string to)
        {
            switch (to)
            {
                case "Centimeters":
                    return (double)input * 100;
                case "Feet":
                    return (double)input * 3.28084;
                case "Inches":
                    return (double)input * 39.3701;
                case "Kilometers":
                    return (double)input * 0.001;
                case "Miles":
                    return (double)input * 0.000621371;
                case "Millimeters":
                    return (double)input * 1000;
                case "Yards":
                    return (double)input * 1.09361;
                default:
                    return 0;
            }
        }

        private double LengthFromMiles(int input, string to)
        {
            switch (to)
            {
                case "Centimeters":
                    return (double)input * 160934;
                case "Feet":
                    return (double)input * 5280;
                case "Inches":
                    return (double)input * 63360;
                case "Kilometers":
                    return (double)input * 1.60934;
                case "Meters":
                    return (double)input * 1609.34;
                case "Millimeters":
                    return (double)input * 1609340.0007802;
                case "Yards":
                    return (double)input * 1760;
                default:
                    return 0;
            }
        }

        private double LengthFromMillimeters(int input, string to)
        {
            switch (to)
            {
                case "Centimeters":
                    return (double)input * 0.1;
                case "Feet":
                    return (double)input * 0.003280841666667;
                case "Inches":
                    return (double)input * 0.0393701;
                case "Kilometers":
                    return (double)input * 0.000001;
                case "Meters":
                    return (double)input * 0.001;
                case "Miles":
                    return (double)input * 0.00000062;
                case "Yards":
                    return (double)input * 0.00109361;
                default:
                    return 0;
            }
        }

        private double LengthFromYards(int input, string to)
        {
            switch (to)
            {
                case "Centimeters":
                    return (double)input * 91.44;
                case "Feet":
                    return (double)input * 0.0009144;
                case "Inches":
                    return (double)input * 36;
                case "Kilometers":
                    return (double)input * 0.0009144;
                case "Meters":
                    return (double)input * 0.9144;
                case "Miles":
                    return (double)input * 0.000568182;
                case "Millimeters":
                    return (double)input * 914.4;
                default:
                    return 0;
            }
        }
        #endregion

        #region Temperature 
        public double GetTemperature(int input, string from, string to)
        {
            if (string.Equals(from, to, StringComparison.OrdinalIgnoreCase))
                return input;

            switch (from)
            {
                case "Celcius":
                    return TempFromCelcius(input, to);
                case "Farenheit":
                    return TempFromFarenheit(input, to);
                case "Kelvin":
                    return TempFromKelvin(input, to);
            }
            return 0;
        }

        private double TempFromCelcius(int input, string to)
        {
            switch (to)
            {
                case "Farenheit":
                    return (double)input * (9 / 5) + 32; ;
                case "Kelvin":
                    return (double)input + 273.15;               
                default:
                    return 0;
            }
        }

        private double TempFromFarenheit(int input, string to)
        {
            switch (to)
            {
                case "Celcius":
                    return ((double)input - 32) * (5 / 9);
                case "Kelvin":
                    return (5 / 9) * ((double)input - 32) + 273.15;
                default:
                    return 0;
            }
        }


        private double TempFromKelvin(int input, string to)
        {
            switch (to)
            {
                case "Celcius":
                    return (double)input - 273.15;
                case "Farenheit":
                    return ((double)input - 273.15) * (9 / 5) + 32;
                default:
                    return 0;
            }
        }
        #endregion

        #region Time
        public double GetTime(int input, string from, string to)
        {
            if (string.Equals(from, to, StringComparison.OrdinalIgnoreCase))
                return input;

            switch (from)
            {
                case "Days":
                    return TimeFromDays(input, to);
                case "Hours":
                    return TimeFromHours(input, to);
                case "Minutes":
                    return TimeFromMinutes(input, to);
                case "Seconds":
                    return TimeFromSeconds(input, to);
            }
            return 0;
        }

        private double TimeFromDays(int input, string to)
        {
            switch (to)
            {
                case "Hours":
                    return (double)input * 24;
                case "Minutes":
                    return (double)input * 1440; ;
                case "Seconds":
                    return (double)input * 86400;
                default:
                    return 0;
            }
        }

        private double TimeFromHours(int input, string to)
        {
            switch (to)
            {
                case "Days":
                    return (double)input / 24;
                case "Minutes":
                    return (double)input * 60; ;
                case "Seconds":
                    return (double)input * 3600;
                default:
                    return 0;
            }
        }

        private double TimeFromMinutes(int input, string to)
        {
            switch (to)
            {
                case "Days":
                    return (double)input / 1440;
                case "Hours":
                    return (double)input / 60;
                case "Seconds":
                    return (double)input * 60;
                default:
                    return 0;
            }
        }

        private double TimeFromSeconds(int input, string to)
        {
            switch (to)
            {
                case "Days":
                    return (double)input / 86400;
                case "Hours":
                    return (double)input / 3600;
                case "Minutes":
                    return (double)input / 60;
                default:
                    return 0;
            }
        }
        #endregion

        #region Weight
        public double GetWeight(int input, string from, string to)
        {
            if (string.Equals(from, to, StringComparison.OrdinalIgnoreCase))
                return input;

            switch (from)
            {
                case "Grams":
                    return WeightFromGrams(input, to);
                case "Kilograms":
                    return WeightFromKilograms(input, to);
                case "Ounces":
                    return WeightFromOunces(input, to);
                case "Pounds":
                    return WeightFromPounds(input, to);
                case "Tons":
                    return WeightFromTons(input, to);
            }
            return 0;
        }

        private double WeightFromGrams(int input, string to)
        {
            switch (to)
            {
                case "Kilograms":
                    return (double)input / 1000;
                case "Ounces":
                    return (double)input / 28.34952;
                case "Pounds":
                    return (double)input * 0.0022046;
                case "Tons":
                    return (double)input / 1000000;
                default:
                    return 0;
            }
        }

        private double WeightFromKilograms(int input, string to)
        {
            switch (to)
            {
                case "Grams":
                    return (double)input * 1000;
                case "Ounces":
                    return (double)input / 0.02834952;
                case "Pounds":
                    return (double)input / 0.45359237;
                case "Tons":
                    return (double)input / 1000;
                default:
                    return 0;
            }
        }

        private double WeightFromOunces(int input, string to)
        {
            switch (to)
            {
                case "Grams":
                    return (double)input * 28.34952;
                case "Kilograms":
                    return (double)input * 0.02834952; 
                case "Pounds":
                    return (double)input / 16;
                case "Tons":
                    return (double)input / 35273.9619;
                default:
                    return 0;
            }
        }

        private double WeightFromPounds(int input, string to)
        {
            switch (to)
            {
                case "Grams":
                    return (double)input / 0.0022046;
                case "Kilograms":
                    return (double)input * 0.45359237; 
                case "Ounces":
                    return (double)input * 16;
                case "Tons":
                    return (double)input / 2204.6226199999; 
                default:
                    return 0;
            }
        }

        private double WeightFromTons(int input, string to)
        {
            switch (to)
            {
                case "Grams":
                    return (double)input * 1000000;
                case "Kilograms":
                    return (double)input * 1000;
                case "Ounces":
                    return (double)input * 35273.9619;
                case "Pounds":
                    return (double)input * 2204.6226199999; 
                default:
                    return 0;
            }
        }
        #endregion  
    }
}