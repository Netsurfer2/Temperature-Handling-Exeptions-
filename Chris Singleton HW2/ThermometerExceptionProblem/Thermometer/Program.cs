/*******************************************************************************************
 * Class: Programming 120  (Classes and Objects)                                           *
 * Project: HW2 Thermometer                                                                *
 * Professor: Kurt Friedrich                                                               *
 * Name: Chris Singleton                                                                   *
 * Date: 10/01/2016                                                                        *
 *******************************************************************************************
 * Summary: 1. User inputs a number and the string changes values in the console.          *
 *          2. Console application references the library solution for temperature state.  *
 *          3. Methods convert to double and calculate temperature while passing as string.*
 *          4. Static fields are private so only what is in the library can reference.     *
 *          5. To convert to double, a method is called directly.                          *
 *          6. Try Catch, write Ex to console from classlibrary during throw of exception. *
 ******************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Thermometer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a test class that creates an instance of a thermometer, 
              displays the current Celsius and Fahrenheit temperature.*/

            Console.Write("\nThis is a test of the Thermometer Class\n");

            //======================== Set 1 c = 0, f = 32 ================================
            Console.Write("\nThe current temp is: {0}\u00B0C\nThe current temp is: {1}\u00B0F\n"
                          , ThermometerClass.CelsiusTemperature, ThermometerClass.FahrenheitTemperature);

            //======================== Set 2 c = 50, f = 122 ==============================
            // Adds 50 degrees Celsius to it and then displays the Celsius and Fahrenheit temperature.
            ThermometerClass.AddCelsius("50"); // 0 + 50 = 50c
            Console.Write("\nThe current temp is: {0}\u00B0C\nThe current temp is: {1}\u00B0F\n"
                          , ThermometerClass.CelsiusTemperature, ThermometerClass.FahrenheitTemperature);

            //======================== Set 3 c = 36.11111111, f = 97 =======================
            // Adds -25 degrees Fahrenheit to it and then displays the Celsius and Fahrenheit temperature.
            ThermometerClass.AddFahrenheit("-25"); // 122 -25 = 97f
            Console.Write("\nThe current temp is: {0}\u00B0C\nThe current temp is: {1}\u00B0F\n"
                          , ThermometerClass.CelsiusTemperature, ThermometerClass.FahrenheitTemperature);

            //==================== Try Catch with current values displayed =================
            /* Allow the user to change the value. Call the Methods ThermometerClass.CelsiusTemperature,
              FahrenheitTemperature in the ClassLibrary to get the current temperature states while writing
              them out to the console. Use try catch to catch any exceptions and throw an application exception.*/
            try
            {
                Console.Write("\nEnter a Celsius value to change the temperature by: ");
                ThermometerClass.AddCelsius(Console.ReadLine());
                Console.Write("\nThe current temp is: {0}\u00B0C\nThe current temp is: {1}\u00B0F\n" +
                              "\nPress any key to exit the program."
                              , ThermometerClass.CelsiusTemperature, ThermometerClass.FahrenheitTemperature);

                Console.ReadKey(); // Pause before ending.

            }/* If so, Catch the exception and write out the current temperature state that was not changed (ThermometerClass.Method).
                Send the Exception Message from the ClassLibrary to the string and Application Exception box that is being thrown.
                Display the current values of both Celsius and Fahrenheit Temperatures.*/
            catch (Exception e) 
            {
                Console.Write("\n"+e.Message+"\nThe temperature setting was not changed.\n"+
                              "The current temp is: {0}\u00B0C \nThe current temp is: {1}\u00B0F"
                              , ThermometerClass.CelsiusTemperature, ThermometerClass.FahrenheitTemperature);
                {
                    throw new ApplicationException(e.Message); // Solve the exception by throwing a new application exception.

                }
            }
            
        }
        
    }
    
} 
