using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05___Triangle_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA, sideB, sideC; //Creates three variables that represents each of the triangle sides 
            Console.WriteLine("This program can check if it's possible to make a triangle from the users input. In order to make a triangle, the sides lenght must meet a certain condition called the 'Triangle Inequality'."); //Asks the user for the input and gives
            Console.Write("Please, give the length of the first side: "); //Asks the user for the input
            sideA = Convert.ToInt32(Console.ReadLine()); //Reads and converts the input from a string to an integer 
            Console.Write("Please, give the length of the second side: "); //Asks the user for the input
            sideB = Convert.ToInt32(Console.ReadLine()); //Reads and converts the input from a string to an integer
            Console.Write("Please, give the length of the third side: "); //Asks the user for the input
            sideC = Convert.ToInt32(Console.ReadLine()); //Reads and converts the input from a string to an integer
            SkipLine();
            if (IsTriangle(sideA, sideB, sideC)) //Calls the Method created and already enters the output of the method in a conditional statement
            {
                Console.WriteLine("This triangle exists!!"); //If the Triangle Inequality condition is met, it will print on the screen that the triangle exists and will also enter in a series of conditional statements
                SkipLine();
                if (sideA == sideB && sideB == sideC) //This first condition checks if the triangle is equilateral, that means that all the sides are simultaneoulsy equal in length
                {
                    Console.WriteLine("The triangle is Equilateral"); //Prints the output
                    SkipLine();
                }
                else if (sideA == sideB && sideB != sideC || sideA == sideC && sideC != sideB || sideB == sideC && sideC != sideA) //This condition is a little bit trick, but it checks all the possible cases (at least I think) for a Isosceles Triangle
                { //The condition above checks individually every case in which two sides have the same length while the third one has a different length. If that sub-condition is met, then it will print that output
                    Console.WriteLine("The triangle is Isosceles");
                    SkipLine();
                }
                else //If none of the conditions above are met, that means that the triangle is a scalene triangle, having sides with different sizes.
                {
                    Console.WriteLine("The triangle is scalene");
                    SkipLine();
                }
            }
            else //If the method returns a false statement, then it will print on the screen that the triangle inequality is not being respected 
            {
                Console.WriteLine("This triangle can't exist because the triangle inequality is not being respect");
                SkipLine();
            }
        }

        static bool IsTriangle (int a, int b, int c) 
        {   //The statements below is based on the "triangle inequality" statement
            //For a better explanation check: https://en.wikipedia.org/wiki/Triangle_inequality
            if (a <= b + c && b <= a + c && c <= a + b) //After checking if all the sides are ok according to the triangle inequality statement, the code will give a proper output for it
            {                                           
                return true; //output if the conditions are met, note that all the possibilites must be checked and met simultaneously
            }
            else
            {
                return false; //output if the conditions aren't met
            }
        }

        static void SkipLine()
        {
            Console.WriteLine("");
        }
    }
}
