using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05___Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            if (GenerateQuestion()) //This statement call the method and tests the it's output. If the output is true, then it will print on the screen "Congratulations" 
            {
                Console.WriteLine("Congratulations");
            }
            else //Otherwise, if the statement is wrong, the output is will be a "You answered incorrectly, please try again!" message
            {
                Console.WriteLine("You answered incorrectly, please try again!");
            }

            SkipLine();

            if (GenerateQuestion()) //This statement call the method and tests the it's output. If the output is true, then it will print on the screen "Congratulations" 
            {
                Console.WriteLine("Congratulations");
            }
            else //Otherwise, if the statement is wrong, the output is will be a "You answered incorrectly, please try again!" message
            {
                Console.WriteLine("You answered incorrectly, please try again!");
            }

            SkipLine();

            if (GenerateQuestion()) //This statement call the method and tests the it's output. If the output is true, then it will print on the screen "Congratulations" 
            {
                Console.WriteLine("Congratulations");
            }
            else //Otherwise, if the statement is wrong, the output is will be a "You answered incorrectly, please try again!" message
            {
                Console.WriteLine("You answered incorrectly, please try again!");
            }

            SkipLine();

        }

        static bool GenerateQuestion()
        {
            Random rndm = new Random(); //Statements that we use to create random numbers "randomly" 
            int a, b, answer, correct_answer; //Create the integer variables that we are going to use througout our code
            a = rndm.Next(1, 1001); //Creates the first random number from 1 to 1000 and assign it to "a"
            b = rndm.Next(1, 1001); //Creates the second random number from 1 to 1000 and assign it to "B"
            Console.WriteLine("  {0,3:D}", a); //In this way you can print the number "a" in the format that was asked 
            Console.WriteLine("+ {0,3:D}", b); //In this way you can print the number "b" in the format that was asked 
            Console.WriteLine("-------"); //Prints the line that separates the numbers that are going to be summed 
            Console.Write(" "); //Creates a small blank space that makes the formatting "perfect"
            answer = Convert.ToInt32(Console.ReadLine()); //This is the command line that allows the user to enter a number
            correct_answer = a + b; //This is correct number that comes from the sum of "a" and "b"
            if (answer==correct_answer) //This is the statement that compares the correct_answer with the actual answer that the user entered and compares the result
            {
                return true; //Return True statement
            }
            else //If the answer is not equal to the correct_answer then the output is false
            {
                return false; //Return false statement
            }
        }

        static void SkipLine()
        {
            Console.WriteLine();
        }

    }
}
