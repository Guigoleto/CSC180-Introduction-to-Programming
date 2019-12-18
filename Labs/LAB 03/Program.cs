using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempF;
            Console.WriteLine("If you enter a temperature in Fahrenheit Degrees, I can convert it to Celsius Degrees");
            tempF = Convert.ToDouble(Console.ReadLine());
            DisplayCelsius(tempF);
            Example("Text");
            Example("5");
        }
       
        static void DisplayCelsius (double tempF)
        {
            double tempC;
            tempC = Math.Round(5.0 * (tempF - 32.0) / 9.0 , 2);
            Console.WriteLine("You have entered the temperature {0}F", tempF);
            Console.WriteLine("The temperature {0}F is equivalent to {1}C", tempF, tempC);
        }

        static void Example (string whatever)
        {
            Console.WriteLine(whatever);
        }
    }
}
