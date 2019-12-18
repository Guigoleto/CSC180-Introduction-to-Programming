using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, I'm going to call a Method that will display the exact same message that you enter as many times as you want\n");
            Console.Write("Enter the message that you would like to see printed on the screen: ");
            string input = Console.ReadLine();
            Console.Write("Enter the number of times that you want to see that message printed on the screen: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number)) //This is a fancy way to make an input validation that I've found on the internet while practicing for another code. Basically, this statement is going to read the user's input and if it doens't satisfy the condition (in this case, being an int) then it will create a loop that will only be broken whenever the user enters a valid input, in this case, an int
            {//But whenever the user inputs a valid number, it will be assigned to that variable that is being tested
                Console.WriteLine("Sorry, your input is not available.");
                Console.Write("Please enter a valid number of times that you want to see that message printed on the screen: ");
            }
            PrintMultiple(input, number);
            Console.WriteLine("\nThank you for participating!\n");
        }

        static void PrintMultiple (string str, int num)
        {
            while(num>0)
            {
                Console.WriteLine("\n{0}", str);
                num--;
            }
        }
    }
}
