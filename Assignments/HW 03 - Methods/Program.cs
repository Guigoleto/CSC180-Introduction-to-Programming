using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Problem 1:");
            Console.WriteLine("If you give me two integers I can calculate the average of them");
            Console.Write("Please, give me the first number: "); //Asks the user to enter one number
            num1 = Convert.ToInt32(Console.ReadLine()); //Reads the user input and convert it from a string to an integer
            Console.Write("Now, please give me the second number: "); //Asks the user to enter another number
            num2 = Convert.ToInt32(Console.ReadLine()); //Reads the user input and convert it from a string to an integer
            WriteAverage(num1, num2); //Invokation of the WriteAverage method and use num1 and num2 as parameters to run the method
            SkipLine(); //Calling the SkipLine method for aesthetic output
            SkipLine(); //Calling the SkipLine method for aesthetic output

            int year, date;
            string month, day;

            Console.WriteLine("In order to solve problems 2, 3, 4 and 5, I'd like to ask you a few questions"); 
            SkipLine(); //Calling the SkipLine method for aesthetic output
            Console.Write("Please, could you tell me the year that you were born? "); //Asks the user for the year that he was born
            year = Convert.ToInt32(Console.ReadLine()); //Reads the user input and convert it from a string to an integer 
            SkipLine(); //Calling the SkipLine method for aesthetic output
            Console.Write("Now I need to know that month that you were born: "); //Asks the user for the month that he was born 
            month = Console.ReadLine(); //Reads the user input 
            SkipLine();//Calling the SkipLine method for aesthetic output
            Console.Write("Now, if you don't mind, give the date(day of the month) that you were born: "); //Asks the user for the date that he was born
            date = Convert.ToInt32(Console.ReadLine()); //Reads the user input and convert it from a string to an integer 
            SkipLine(); //Calling the SkipLine method for aesthetic output
            Console.Write("Now I'd like to know the day of the week that corresponds to your birthday: "); //Asks the user for the day that he was born
            day = Console.ReadLine();  //Reads the user input

            Console.WriteLine("Problems 2 and 3");
            WriteEuropean(day, date, month, year); //invokation of the WriteEuropean method, as well as the value assignment of the method's parameters
            SkipLine(); // calling the SkipLine method for aesthetic output
            SkipLine(); // calling the SkipLine method for aesthetic output


            Console.WriteLine("Problems 4 and 5");
            WriteAmerican(day, date, month, year); //invokation of the WriteAmerican method, as well as the value assignment of the method's parameters
            SkipLine(); // calling the SkipLine method for aesthetic output
            SkipLine(); // calling the SkipLine method for aesthetic output
        }


        static void WriteAverage(int num1, int num2)
        {
            double average = (num1 + num2) / 2.0;
            //That math operation uses the two method parameters num1 and num2, sum them and divide it by 2.0 creating a double ouput
            Console.WriteLine("The average of the numbers {0} and {1} is {2}", num1, num2, average);
            //Displays the outputs in that order
        }
        static void WriteEuropean(string day, int date, string month, int year)
        { //this method has 4 parameters, the day parameter is for the weekdays, the dat is for the month days, month is for month and year is for year
            Console.WriteLine("My birthday in the European calendar is : {0} {1} {2}, {3}", day, date, month, year);
        } //the statement above displays the outputs in the European calendar order: day of the week followed by the month day, month and year
        static void WriteAmerican(string day, int date, string month, int year)
        { // this method uses the same idea of the european method, the main difference is that here you have the month and daymonth places switched
            Console.WriteLine("My birthday on the American Calendar is : {0} {1} {2}, {3}", day, month, date, year);
        }
        static void SkipLine()
        { //this method was created just skip a line, just for aesthetic purposes 
            Console.WriteLine();
        }
    }
}
