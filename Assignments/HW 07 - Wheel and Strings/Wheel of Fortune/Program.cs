using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_07___Alternative_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            ///CountLines
            //This code will count how many lines there are in the file that I'm using to "feed" the Wheel of Fortune 
            Console.WriteLine("The file that I'm using to feed the Wheel of Fortune has {0} lines", CountLines("input.txt"));


            ///ReverseString
            // Asks the user to enter a string and it will reverse the word using the method
            Console.Write("\nEnter a string and I'll reverse it: ");
            string user_input = Console.ReadLine();
            // This amount of "\t" is just for aesthetic purposes because the reversed word will be just under the entered word
            Console.WriteLine("The reversed string is: " + ReverseString(user_input));


            ///ReverseNumber
            // Asks the user to enter an int and it will reverse the int using the method
            Console.Write("\nEnter an integer number and I'll reverse it: ");
            int user_num;
            while (!int.TryParse(Console.ReadLine(), out user_num))
            {
                Console.WriteLine("Sorry, but the number you entered is not valid");
                Console.Write("Please, enter a valid number to be reversed: ");
            }
            Console.WriteLine("The reversed number is: {0}", ReverseNumber(user_num));


            ///Two doubles comparer 
            // Asks the user to enter two double number
            Console.WriteLine("\nEnter two double numbers and I'll compare them and return the smallest");
            Console.Write("Enter the first number: ");
            double n1;
            while (!double.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Sorry, but the number you entered is not valid");
                Console.Write("Please, enter a valid number to be reversed: ");
            }

            Console.Write("Enter the second number: ");
            double n2;
            while (!double.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Sorry, but the number you entered is not valid");
                Console.Write("Please, enter a valid number to be reversed: ");
            }
            Console.WriteLine("From the two numbers that you entered, {0} and {1}, the smallest is {2}", n1, n2, Min(n1, n2));


            ///CountChar
            //This code will call the user and ask him to enter a string and it will count how many character this string has
            Console.WriteLine("\nIf you give me a string, I'll count how many characters it has");
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("The amout of character that the string has is {0}", CountChar(str));

        }

        static string ReverseString(string word)
        {
            // I created a new word because it makes the job easier
            string reversedWord = "";
            // I'm going to use this index to run the "word" backwards
            int index = word.Length - 1;

            while (index >= 0)
            {
                // This statement will gradually add the letters backwards
                reversedWord += word[index];
                index--;
            }

            return reversedWord;
        }

        static int ReverseNumber(int num)
        {
            // I'm using the ReverseString Method that I already created 
            // But as the parameter of the ReverseString only accept strings as parameters I need to convert the parameter of the ReverseNumber to a string 
            string s = Convert.ToString(num);
            int reverse_num = Convert.ToInt32(ReverseString(s));
            return reverse_num;

        }

        static double Min(double n1, double n2)
        {
            // If n1 is bigger then n2 then I'll return the n2
            if (n1 > n2)
            {
                return n2;
            }

            // If n2 is bigger then n1 then I'll return the n1
            else if (n1 < n2)
            {
                return n1;
            }

            // If n1 == n2 doesn't matter which number I'll return because they have the same value so I'll just return n1
            else
            {
                return n1;
            }
        }

        static int CountLines(string input_file)
        {
            // I open the code here and create a counter that I'll use to count howmany lines it has 
            StreamReader file = new StreamReader(input_file);
            int counter = 0;
            // I create a string variable that I'll use to read the lines
            // Take note that I'll keep reading each line and increase the counter as long as I have lines in the file 
            string lines = file.ReadLine();
            while (lines != null)
            {
                counter++;
                lines = file.ReadLine();//read the next line
            }
            // I stop reading the file
            file.Close();
            return counter;

        }

        static int CountChar (string str)
        {
            // Creates an index counter that will increase as long as its value is smaller then the size of the string that was entered 
            int index = 0;
            while(index<str.Length)
            {
                index++;
            }

            return index;
        }
    }
}
