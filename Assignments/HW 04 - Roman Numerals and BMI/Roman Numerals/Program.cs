using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_04___Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; //Declares the variable int
            Console.WriteLine("If you give me a number from 1 to 10, I can convert it to its equivalent Roman number"); //Asks the user to enter a number
            number = Convert.ToInt32(Console.ReadLine()); //Reads the user's input and converts it into an integer
            DisplayRomanNumeral(number); //Uses the variable int (from the Main Method) as a parameter for the DisplayRomanNumeral and also invokes the DisplayRomanNumeral Method
        }

        static void DisplayRomanNumeral(int num)
        {
            //The statements below are the conditional statements that compare the parameter with a number and if it's valid, displays the Roman Numeral
            if (num == 1) 
                Console.WriteLine("The number {0} is equivalent to I in Roman number",num);
            else if (num == 2)
                Console.WriteLine("The number {0} is equivalent to II in Roman number", num);
            else if (num == 3)
                Console.WriteLine("The number {0} is equivalent to III in Roman number", num);
            else if (num == 4)
                Console.WriteLine("The number {0} is equivalent to IV in Roman number", num);
            else if (num == 5)
                Console.WriteLine("The number {0} is equivalent to V in Roman number", num);
            else if (num == 6) 
                Console.WriteLine("The number {0} is equivalent to VI in Roman number", num);
            else if (num == 7)
                Console.WriteLine("The number {0} is equivalent to VII in Roman number", num);
            else if (num == 8)
                Console.WriteLine("The number {0} is equivalent to VIII in Roman number", num);
            else if (num == 9)
                Console.WriteLine("The number {0} is equivalent to IX in Roman number", num);
            else if (num == 10)
                Console.WriteLine("The number {0} is equivalent to X in Roman number", num);
            else //This statement is a loop that I've created with conditionals statements with what you told us in class
            {    //If any of the statements above are valid, the code will lead to this condition
                Console.WriteLine("The number {0} is invalid,please enter a valid number", num); //Here they say that the "num" parameter is invalid
                LoopingIf(); //Here they call another method that creates the loop
            }

            /* The ideia is, everytime that the code runs and the user don't enter a valid number, the else statement will display on the screen a message saying that the 
             * number is invalid. This code creates a loop that only stops when the user enter a valid number
             */
           
        }
        static void LoopingIf() //Loop created out of Ifs, Elses and Methods
        {
            int number2; //Creates another variable called number
            Console.WriteLine("The number you entered is not a valid number"); //Display that message on the screen
            Console.WriteLine("Please, give me a number from 1 to 10, I can convert it to its equivalent Roman number"); //Display this other message on the screen
            number2 = Convert.ToInt32(Console.ReadLine()); //Reads the user's input and convert it into an integer
            DisplayRomanNumeral(number2); //Calls back the DisplayRomanNumeral Method and uses this number2 variable to fill the parameter from the DisplayRomanNumeral Method
        }

    }
}
