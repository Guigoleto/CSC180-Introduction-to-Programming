using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand_gen = new Random();
            int[] arr = new int[10];
            for (int i = 0; i<10; i++)
            {
                arr[i] = rand_gen.Next(0,1001);
            }

            Console.WriteLine("Below, there are 10 random numbers ranging from 0 to 1001:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();

            int[] increased_array = IncreaseArray(arr);

            Console.WriteLine("Below, you will find the same 10 random numbers ranging from 0 to 1001, but increased by 10, 20, 30, 40,... :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", IncreaseArray(arr)[i]);
            }

            Console.WriteLine();


        }

        public static int[] IncreaseArray (int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            int add_value = 10;

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i] + add_value;
                add_value += 10;
            }
            return arr2;
        }
    }
}
