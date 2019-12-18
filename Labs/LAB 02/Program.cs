using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1");
            int x, y, z; //I just declared the three int variables that I'll use as "inputs"
            int sum, average; // I just declared the sum variable and the average variable
            x = 12;
            y = 18;
            z = 24;
            sum = x + y + z;
            average = (x + y + z) / 3;
            Console.WriteLine("The numbers you choose are {0},{1} and {2}", x, y, z);
            Console.WriteLine("The sum of all these three numbers is {0}", sum);
            Console.WriteLine("The average of all these three numbers {0}", average);
            Console.WriteLine();
            Console.WriteLine("Problem 2");
            double force, area, pressure;
            force = 172.5;
            area = 27.5;
            pressure = area / force;
            Console.WriteLine("Following the 'recipe' the pressure is equivalent to {0}",pressure);
            Console.WriteLine();
                       
        }
    }
}
