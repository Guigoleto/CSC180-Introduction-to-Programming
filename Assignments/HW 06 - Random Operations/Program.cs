using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06___Asterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("I'm going to call a Method that is going to display asterisks on the screen according to the number you enter\n"); //Display on the screen the First Method's Objective
            Console.Write("Please enter a number: ");
            int x ; //Declare the variable "x" that is going to be used to fill the DisplayAsterisks' parameter
            while(!int.TryParse(Console.ReadLine(),out x)) //This is a fancy way to make an input validation that I've found on the internet while practicing for another code. Basically, this statement is going to read the user's input and if it doens't satisfy the condition (in this case, being an int) then it will create a loop that will only be broken whenever the user enters a valid input, in this case, an int
            {//But whenever the user inputs a valid number, it will be assigned to that variable that is being tested
                Console.WriteLine("Sorry, your input is not available.");
                Console.Write("Please enter a valid number: ");
            }
            DisplayAsterisks(x); //Finally, uses that valid input as a parameter and runs the method 
           
            Console.Write("\nEnter today's sales for store 1: ");
            int input1;
            while (!int.TryParse(Console.ReadLine(), out input1)) //This is a fancy way to make an input validation that I've found on the internet while practicing for another code. Basically, this statement is going to read the user's input and if it doens't satisfy the condition (in this case, being an int) then it will create a loop that will only be broken whenever the user enters a valid input, in this case, an int
            {//But whenever the user inputs a valid number, it will be assigned to that variable that is being tested
                Console.WriteLine("Sorry, your input is not available.");
                Console.Write("Please enter a valid sales number for store 1: ");
            }
            Console.Write("Enter today's sales for store 2: ");
            int input2;
            while (!int.TryParse(Console.ReadLine(), out input2)) //This is a fancy way to make an input validation that I've found on the internet while practicing for another code. Basically, this statement is going to read the user's input and if it doens't satisfy the condition (in this case, being an int) then it will create a loop that will only be broken whenever the user enters a valid input, in this case, an int
            {//But whenever the user inputs a valid number, it will be assigned to that variable that is being tested
                Console.WriteLine("Sorry, your input is not available.");
                Console.Write("Please enter a valid sales number for store 2: ");
            }
            Console.Write("Enter today's sales for store 3: ");
            int input3;
            while (!int.TryParse(Console.ReadLine(), out input3)) //This is a fancy way to make an input validation that I've found on the internet while practicing for another code. Basically, this statement is going to read the user's input and if it doens't satisfy the condition (in this case, being an int) then it will create a loop that will only be broken whenever the user enters a valid input, in this case, an int
            {//But whenever the user inputs a valid number, it will be assigned to that variable that is being tested
                Console.WriteLine("Sorry, your input is not available.");
                Console.Write("Please enter a valid sales number for store 3: ");
            }
            Console.Write("Enter today's sales for store 4: ");
            int input4;
            while (!int.TryParse(Console.ReadLine(), out input4)) //This is a fancy way to make an input validation that I've found on the internet while practicing for another code. Basically, this statement is going to read the user's input and if it doens't satisfy the condition (in this case, being an int) then it will create a loop that will only be broken whenever the user enters a valid input, in this case, an int
            {//But whenever the user inputs a valid number, it will be assigned to that variable that is being tested
                Console.WriteLine("Sorry, your input is not available.");
                Console.Write("Please enter a valid sales number for store 4: ");
            }
            Console.Write("Enter today's sales for store 5: ");
            int input5;
            while (!int.TryParse(Console.ReadLine(), out input5)) //This is a fancy way to make an input validation that I've found on the internet while practicing for another code. Basically, this statement is going to read the user's input and if it doens't satisfy the condition (in this case, being an int) then it will create a loop that will only be broken whenever the user enters a valid input, in this case, an int
            {//But whenever the user inputs a valid number, it will be assigned to that variable that is being tested
                Console.WriteLine("Sorry, your input is not available.");
                Console.Write("Please enter a valid sales number for store 5: ");
            }
            AsterisksPerSale(input1, input2, input3, input4, input5);
        }
        
        static void DisplayAsterisks (int num) //This is the method that requires a num as a parameter
        {
            SkipLine();
            int count = num; //In this statement, I'm actually saving the initial value of "num" in "count" because then I'll be able to make a prettier conclusion output
            while(num > 0) //This statement creates a loop that you "happen" as long as num's value is greater then 0
            {
                Console.Write("*"); //This statement allows the asterisks to be displayed in the same line
                --num; //A fancier way to write a decrement, in this statement num's value is being decreased by 1 everytime this loop "loops"
            }
            Console.WriteLine("\n\nYou have entered {0} and this code printed on the screen {1} asterisk(s)", count, count); //Prettier output that jumps a line from the last line before writting it's message.
        }  // Also, I'm using the "count" variable now to actually display the value that the user entered and the number of asterisks that is being displayed on the screen based on that number

        static void AsterisksPerSale(int sales1, int sales2, int sales3, int sales4, int sales5)
        {
            Console.WriteLine("SALES BAR CHART"); //Displays on the screen that message
            Console.WriteLine("(Each * = $100)"); //Displays on the screen that message
            Console.Write("\nStore 1: "); 
            while( sales1 > 99) //This loop will count the hundreds that are within the number was entered by the user. The dozens and units are "ignored" because they don't matter for our purpose
            { //To ignore the remaining dozens and units I created that condition above, as long as the number is greater than 99 it will keep being decreased by 100
                Console.Write("*"); //As the loop "loops" it will print on the screen a "*"
                sales1 = sales1 - 100;
            }

            Console.Write("\nStore 2: ");
            while (sales2 > 99) //This loop will count the hundreds that are within the number was entered by the user. The dozens and units are "ignored" because they don't matter for our purpose
            { //To ignore the remaining dozens and units I created that condition above, as long as the number is greater than 99 it will keep being decreased by 100
                Console.Write("*"); //As the loop "loops" it will print on the screen a "*"
                sales2 = sales2 - 100;
            }

            Console.Write("\nStore 3: ");
            while (sales3 > 99) //This loop will count the hundreds that are within the number was entered by the user. The dozens and units are "ignored" because they don't matter for our purpose
            { //To ignore the remaining dozens and units I created that condition above, as long as the number is greater than 99 it will keep being decreased by 100
                Console.Write("*"); //As the loop "loops" it will print on the screen a "*"
                sales3 = sales3 - 100;
            }

            Console.Write("\nStore 4: ");
            while (sales4 > 99) //This loop will count the hundreds that are within the number was entered by the user. The dozens and units are "ignored" because they don't matter for our purpose
            { //To ignore the remaining dozens and units I created that condition above, as long as the number is greater than 99 it will keep being decreased by 100
                Console.Write("*"); //As the loop "loops" it will print on the screen a "*"
                sales4 = sales4 - 100;
            }

            Console.Write("\nStore 5: ");
            while (sales5 > 99) //This loop will count the hundreds that are within the number was entered by the user. The dozens and units are "ignored" because they don't matter for our purpose
            { //To ignore the remaining dozens and units I created that condition above, as long as the number is greater than 99 it will keep being decreased by 100
                Console.Write("*"); //As the loop "loops" it will print on the screen a "*"
                sales5 = sales5 - 100;
            }

            SkipLine();
            SkipLine();
        }

        static void SkipLine()
        {
            Console.WriteLine();
        }

    }
}
