using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_055
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;
            Console.WriteLine("Hello, I've created a method that can calculates the average of two numbers of yoru choice");
            SkipLine();
            Console.Write("Please, give me the first number:  ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, give me the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("The average of these two numbers is: ");
            Console.WriteLine(Average(firstNumber, secondNumber));
            SkipLine();
            SkipLine();
            SkipLine();
            SkipLine();
            Console.WriteLine("I've had created another method that checks if the a number is divisible by another one");
            Console.WriteLine("To check if that's true, first pick a number and we'll see if the first number is divisible by the second number");
            SkipLine();
            Console.Write("Give me the number that we'll check if it is divisible: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now, give me the number that we'll use to divide the first one: ");
            fourthNumber = Convert.ToInt32(Console.ReadLine());
            if(IsDivisible(thirdNumber, fourthNumber))
            {
                Console.WriteLine("The number {0} is divisible by {1}", thirdNumber,fourthNumber);
            }
            else
            {
                Console.WriteLine("The number {0} is not divisible by {1}", thirdNumber, fourthNumber);
            }
        }

        static double Average(int n, int m)
        {
            double ndouble, mdouble;
            ndouble = Convert.ToDouble(n);
            mdouble = Convert.ToDouble(m);
            double average = Math.Round((ndouble + mdouble)/2.0, 1);
            return average;
        }

        static bool IsDivisible(int n, int m)
        {
            if (n % m == 0)
                return true;
            else
                return false;
        }

        static void SkipLine()
        {
            Console.WriteLine();
        }
    }
}
