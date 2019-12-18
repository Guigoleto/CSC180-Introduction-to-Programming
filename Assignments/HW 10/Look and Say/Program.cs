using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_10___Look_and_Say
{
    class Program
    {
        // StreamReader is reading the file 
        // this method is reading all the files and putting them on the "lines" array
        // The reason why I put them here is to be able of calling the lines array in other parts of the code
        static StreamReader input = new StreamReader("input.txt");
        static string[] lines = File.ReadAllLines("input.txt");

        static void Main(string[] args)
        {
            LookAndSay();
        }

        static int TestCases()
        {
            // Like the Problem told us to do, the first number is our test case number
            int test_cases = Convert.ToInt32((lines[0]));
            // It returns the value so I can use them later
            return test_cases;
            // If the number of cases is smaller or equal to the amount of years you have on the .txt file, the program is going to be cool
            // If the number fo cases is greater then the amount of years you have on the .txt file, the program crash because of "an index" problem
        }

        static void LookAndSay()
        {

            char[] arr1 = Console.ReadLine().ToCharArray();
            int counter = 1;
            for (int i = 0; i < arr1.Length; i++)
            {

                for (int u = i + 1; u < arr1.Length; u++)
                {
                    if (arr1[i] == arr1[u])
                    {
                        counter++;
                    }

                    else
                    {
                        Console.Write(counter);
                        Console.Write(arr1[i]);
                        i = u - 1;
                        counter = 1;
                        break;
                    }
                }

            }
            Console.Write(counter);
            Console.Write(arr1[arr1.Length - 1]);
        }
    }
}
