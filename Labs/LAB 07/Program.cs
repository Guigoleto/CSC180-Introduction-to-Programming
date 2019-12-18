using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you give me a string line and choose a any character, I'll count how many times that character appears on that string");
            Console.Write("First, give me the string line: ");
            string line = Console.ReadLine();
            Console.Write("Now, give me the character that we are going to use: ");
            char c;
            while (!char.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Sorry, your input is not available.");
                Console.Write("Please enter a valid character: ");
            }

                Console.WriteLine(CountLetter(line, c));
        }

        static int CountLetter( string str, char ch)
        {
            int counter = 0;
            int index = 0;
            while ( index < str.Length)
            {
                if (str[index] == ch)
                {
                    counter++;
                }
                index++;
            }
            return counter;
        }
    }
}
