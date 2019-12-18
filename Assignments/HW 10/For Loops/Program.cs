using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace HW_10___Extra_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            //WordCount();

            //LookAndSay();
        }

        // Unfinished
        static void NthLargest ()
        {
            Console.WriteLine("Enter a string of number separated by space");

            string[] array = Console.ReadLine().Split();
            int[] number_array = new int[array.Length];
            int[] largest = new int[3];
            for (int u = 0 ; u < array.Length; u++)
            {
                number_array[u]=Convert.ToInt32(array[u]);
            }
        }

        // Unfinished
        static void WordCount()
        {
            StreamReader input = new StreamReader("input.txt");
            string[] lines = File.ReadAllLines("input.txt");
            int lines_counter = 0;
            for (int i =0; i < lines.Length; i++)
            {
                lines_counter++;
            }

            Console.WriteLine(lines_counter); 
        }
    }
}
