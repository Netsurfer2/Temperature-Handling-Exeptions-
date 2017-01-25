using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class ThermometerClass
    {
        // private static fields, so reference can only be done in the library.
        private static double _CelsiusTemperature;
        private static double _FahrenheitTemperature;

        // static constructor sets the original values of temperatures.
        static ThermometerClass()
        {
            _CelsiusTemperature = 0;
            _FahrenheitTemperature = 32;
        }

        //========================== Get Temperatures / Set Temperature Values ==========================
        /* two static properties, one called CelsiusTemperature  and the other FahrenheitTemperature
           (gets the field values and returns new set field values).*/
        public static double CelsiusTemperature
        {
            get
            {
                return _CelsiusTemperature;
            }
            set
            {
                _CelsiusTemperature = value;
            }
        }

        public static double FahrenheitTemperature 
        {
            get
             {
                 return _FahrenheitTemperature;
             }
            set
            {
                _FahrenheitTemperature = value;
            }
        }

        //=========================== Add / Pass Temperatures to convertToDouble ========================

        /* Two static methods, one called AddCelsius  and the other AddFahrenheit, both of which take in a STRING.
           (Call convert to double, then append temperature, then call to change the other temperature.)*/
        public static void AddCelsius(string CelsiusTemperature1)
        {
            CelsiusTemperature += ConvertInputToDouble(CelsiusTemperature1); 
            CelsiusToFahrenheit(CelsiusTemperature.ToString()); 
        }

        public static void AddFahrenheit(string FahrenheitTemperature1)
        {
            
            FahrenheitTemperature += ConvertInputToDouble(FahrenheitTemperature1); 
            FahrenheitToCelsius(FahrenheitTemperature.ToString()); 
        }

        //========================= Convert to Double / Catch Exceptions ================================

        /* Initialize and parse the variable temp to double, catch the exeption while displaying
           text in the exception box (message is sent to the console program.cs), console window 
           and return the current temperatures.*/
        private static double ConvertInputToDouble(string pTempString)
        {   
            double temp = 0.0;
            try
            {
                temp = Double.Parse(pTempString);
            }
            catch (Exception e)
            {
                throw new ApplicationException("That was not a valid temperature.");
            }
            return temp;
        }

        //================= Calculate ConvertTodouble, CelsiusTemperature1 with formula ==================

        /* Convert the string to a double, and BOTH of these 2 methods update BOTH of the fields.
           Call Method ConvertInputToDouble to convert to double while calculating temperatures.*/
        private static void CelsiusToFahrenheit(string CelsiusTemperature1)
        {  
            FahrenheitTemperature = (ConvertInputToDouble(CelsiusTemperature1) * 9 / 5) + 32;
        }

        private static void FahrenheitToCelsius(string FahrenheitTemperature)
        {
            CelsiusTemperature = (ConvertInputToDouble(FahrenheitTemperature) - 32) * 5 / 9; 
        }
    }
}
