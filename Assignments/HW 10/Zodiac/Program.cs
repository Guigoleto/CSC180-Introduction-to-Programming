using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_10___Zodiac
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
            Zodiac();
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

        static void Zodiac()
        {
            // Reads the number of test cases the user entered
            int number_of_cases = TestCases();

            // I'm creating an array that will contain the same number of years as the number of test cases that the user entered 
            // This array will store the years
            int[] years_list = new int[number_of_cases];
            for (int t = 0; t < number_of_cases; t++)
            {
                years_list[t] = Convert.ToInt32(lines[t+1]); //t+1 because if it were just the "t" it would give an error because of the first number on the file which is the number of cases
            }

            // I'm creating an array that will contain the same number of zodiac signs as the number of test cases that the user entered 
            string[] zodiac_list = new string[number_of_cases];

            // Now for I'm calling the method Year on the same amount of times as the value assigned to the test cases variable
            for (int i = 0; i < number_of_cases; i++)
            {
                // Now I'm assigning the the year_zodiac list the corresponding zodiac sign for that year
                zodiac_list[i] = ZodiacSigns(years_list[i]);
            }

            // This part is using syncronizing the two lists so they return the zodiac value corresponding to the year
            for (int u = 0; u < number_of_cases;  u++)
            {
                Console.WriteLine("{0} is the year of the {1}", years_list[u], zodiac_list[u]);
            }


        }


        static string ZodiacSigns(int year)
        {
            // This array will store the zodiac signs
            string[] zodiac_list = { "Snake", "Horse", "Sheep", "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon" };

            // This part will get the number of the year and will subtract by 1965
            // The purpose of the math operation is to create a "starting point" for the list and create a cycle
            // The year 1965 is the Snake year, so in this case, if the value 1965 is entered the "num" variable will be equal to 0 refering to the first item of the array and so goes on
            int num = year - 1965;

            // If numbers greater then 1976 were entered the value of "num" will be greater then the size of the array, therefore I need to "cut down" the number to a value that is ranging from 0 to 11
            // For this reason, I created this loop that will keep decreasing the "num" by 12 as long as it is greater then 11
            while (num > 11)
            {
                num -= 12;
            }

            return zodiac_list[num];
        }
    }
}
