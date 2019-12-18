using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height, bmi;
            Console.WriteLine("If you give me your weight (pounds) and height (inches), I can calculate your BMI."); //Anouces the Program Function
            Console.Write("Please, give me your weight: "); //Asks for the user's weight
            weight = Convert.ToDouble(Console.ReadLine()); //Reads the input and also converts it into a Double
            Console.Write("Now, give me your height: "); //Asks for the user's height
            height = Convert.ToDouble(Console.ReadLine()); //Reads the input and also converts it into   a Double
            bmi = Math.Round((weight * 703) / ((height) * (height)), 2); //MATHEMTATICS
            Console.Write("Your BMI is {0}, that means that ", bmi); //Prints the BMI
                if (bmi < 18.5) //First Condition   
                    Console.WriteLine("you are Underweight");
                else if (bmi <= 25) //Second Condition
                    Console.WriteLine("you are Normal Weight");
                else if (bmi <= 30) //Third Condition
                    Console.WriteLine("you are OverWeight");
                else if (bmi <= 40) //Fourth Condition
                    Console.WriteLine("you are Obese");
                else //Fifth Condition
                    Console.WriteLine("you are Morbidly Obese");
        }
    }
}
