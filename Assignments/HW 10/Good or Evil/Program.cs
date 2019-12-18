using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Good_or_Evil
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
            SetCharName();
        }

        static void SkipLine()
        {
            // Aesthetic purpose
            Console.WriteLine();
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

        static void GoodOrEvil()
        {
            // I called the test case to so I can give the user te option of putting as many inputs as he wants
            int x = TestCases();
        }

        static void SetCharName()
        {
            int number_of_cases = TestCases();

            string[] char_name = new string[number_of_cases];

            for (int t = 0; t < number_of_cases; t++)
            {
                char_name[t] = (lines[t + 1]); //t+1 because if it were just the "t" it would give an error because of the first number on the file which is the number of cases
                char[] arr = char_name[t].ToCharArray();
                // Now I break the user input into a series of char so I can analyze then one by one 

                // Creating two counters, one fore EVIl the other for GOOD
                int evil_counter = 0;
                int good_counter = 0;

                // I created the for loop that will check for every letter and if it finds a 'g' or 'G' it will increase the good counter by one, same goes for the evil counter
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 'e' || arr[i] == 'E')
                    {
                        evil_counter++;
                    }
                    else if (arr[i] == 'g' || arr[i] == 'G')
                    {
                        good_counter++;
                    }
                }

                // Now the comparison part, it will check which counter is bigger (if they are) and it will return a proper output saying the character/person alignment
                if (evil_counter > good_counter)
                {
                    Console.WriteLine("{0} is evil", char_name);
                }
                else if (evil_counter < good_counter)
                {
                    Console.WriteLine("{0} is good", char_name);
                }
                else
                {
                    Console.WriteLine("{0} is neutral", char_name);
                }

                SkipLine();
            }
        }
    }
}
