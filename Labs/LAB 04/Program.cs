using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 101);
            Console.WriteLine("This code will generate a random number and your job here is try to guess which number was generated");
            SkipLine();
            int guess;
            Console.Write("Which number do you think that this code generated? ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < randomNumber)
            {
                SkipLine();
                Console.WriteLine("Too low!!");
                SkipLine();
            }
            else if (guess > randomNumber)
            {
                SkipLine();
                Console.WriteLine("Too High!!");
                SkipLine();
            }
            else if (guess == randomNumber)
            {
                SkipLine();
                Console.WriteLine("Congratulations!!You won!");
                SkipLine();
            }
            Console.WriteLine("The Random Number is {0}", randomNumber);
            SkipLine();
        }

        static void SkipLine()
        {
            Console.WriteLine();
        }
    }
}