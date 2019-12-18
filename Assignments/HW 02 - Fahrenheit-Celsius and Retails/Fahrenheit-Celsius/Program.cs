using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit___Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            Console.WriteLine("Put a temperature here in Fahrenheits Degrees and the program will convert it to Celsius Degrees");
            F = Convert.ToDouble(Console.ReadLine());
            //The Console.Readline() makes the program more interactive
            //The Convert.ToDouble is necessary to convert the input (that comes as a string) to a double
            
            C = Math.Round(5 * (F - 32) / 9,1);
            //The math operation above that is slightly different from the one that was on moodle
            //The Reason it is different is that original "C=5/9 (F-32)" formula would always result in a 0 on C#
            //Unless we change the math operation 5/9, because in that format, the program would fix the output problem
            //The Math.Round allows you to make a round up in a math operation that have decimals
            //And I chose it to make a better conversion
             
            Console.WriteLine("The temperature {0}F is equivalent to {1}C", F, C);
            //In the statement above I just printed the F variable in the place of the {0} and the C variable output in the place {1}
        }
        // 5/9 ; 5.0/9.0
    }
}
