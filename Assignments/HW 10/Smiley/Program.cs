using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace HW_10___Smiley
{
    class Program
    {
        static void Main(string[] args)
        {
            Smiley();
            SkipLine();
        }

        static void Smiley()
        {
            // Opens the file and readl all the lines
            StreamReader input = new StreamReader("input.txt");
            string[] lines = File.ReadAllLines("input.txt");

            // This for loop goes all the way through the lines searching one by one for the pattern
            for (int i = 0; i < lines.Length; i++)
            {
                RegexForSmiley(lines[i]);
            }
        }

        static void RegexForSmiley(string input)
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netframework-4.8
            // Sorry Mezei, I know that you wanted me to use arrays and for loops but I have already learned REGEX in python and I think it's something easier to use when it comes to look for substrings in strings
            // In order to work with REGEX I have to add the library "using System.Text.RegularExpressions;"
            // So basically I'm using the "Regex" class to create a new pattern for searches, which in this situatio is the ":-)"
            // Also, I know from my python classes that there are some special characters that if we want to look specifically for them we need to add "\" before them
            // I looked up on the internet and to do that in C# I need to use "\\" instead of just one "\"
            // I did that with all our characters because talking about REGEX pretty much everything that is not a number or a letter has a special "function"

            // I'm creating the instance and I'm assigning the ":-)" search pattern
            Regex rx = new Regex("\\:\\-\\)");
            // From that I used another class to look for possible matches on the input file by using my "rx" regex pattern
            MatchCollection matches = rx.Matches(input);

            // By using the matches.Count I can actually count how many occurences happens in my input file
            Console.WriteLine("\nThere were a total of {0} matches for the \":-)\" pattern", matches.Count);
        }

        static void SkipLine()
        {
            // Aesthetic purpose
            Console.WriteLine();
        }
    }
}
