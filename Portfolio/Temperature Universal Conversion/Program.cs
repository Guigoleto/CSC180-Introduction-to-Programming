using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Universal_Conversion
{
    class Program
    {

        // Temperature variables
        //https://en.wikipedia.org/wiki/Scale_of_temperature

        public static double C;
        public static double F;
        public static double K;
        public static double Ra;
        public static double Ro;
        public static double Ne;
        public static double De;
        public static double Re;

        static void Main(string[] args)
        {
            TemperatureConversion();
        }

        static void TemperatureConversion()
        {
            //Makes the Temperature Conversion Invitation
            TemperatureFirstInvitation();

            int choice_1 = TemperatureFirstChoiceValidation();
            TemperatureSecondInvitation();
            int choice_2 = TemperatureSecondChoiceValidation();
            ConvertingTemperature(choice_1, choice_2);
        }

        // Invitation to First Choice
        static void TemperatureFirstInvitation()
        {
            // Just the invitation with a formatting
            Console.WriteLine("Choose the scale that you want to convert from: ");
            Console.WriteLine("\n\t1-Celsius \n\t2-Farenheit \n\t3-Kelvin \n\t4-Rankine \n\t5-Rømer \n\t6-Newton \n\t7-Delisle \n\t8-Réaumur \n");
            Console.Write("Your choice: ");
        }

        // Invitation to Second Choice
        static void TemperatureSecondInvitation()
        {
            // Just the invitation with a formatting
            Console.WriteLine("Choose the scale that you want to convert to: ");
            Console.WriteLine("\n\t1-Celsius \n\t2-Farenheit \n\t3-Kelvin \n\t4-Rankine \n\t5-Rømer \n\t6-Newton \n\t7-Delisle \n\t8-Réaumur \n");
            Console.Write("Your choice: ");
        }

        // Validation of the First Choice along with the "getting" of the answer
        // Just like I've done previously
        static int TemperatureFirstChoiceValidation()
        {
            int choice;
            // Input can't be anything other then an int, bigger then 3 or smaller then 1
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 8)
            {
                Console.WriteLine("Sorry, but your input was invalid");
                TemperatureFirstInvitation();
            }
            //returns the input
            return choice;
        }

        //Validation of the Second Choice along with the "getting" of the answer
        // Just like I've done previously
        static int TemperatureSecondChoiceValidation()
        {
            int choice;
            // Input can't be anything other then an int, bigger then 3 or smaller then 1
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 8)
            {
                Console.WriteLine("Sorry, but your input was invalid");
                TemperatureSecondInvitation();
            }
            //returns the input
            return choice;
        }

        static void ConvertingTemperature(int choice_1, int choice_2)
        {
            // This is a list of strings with the name of the scales and its purpose is to make my job easier
            string[] scales = new string[8];
            scales[0] = "Celsius";
            scales[1] = "Farenheit";
            scales[2] = "Kelvin";
            scales[3] = "Rankine";
            scales[4] = "Rømer";
            scales[5] = "Newton";
            scales[6] = "Delisle";
            scales[7] = "Réaumur";

            // Prints some information on the screen and asks the user to enter the value that he wants to be converted
            Console.WriteLine("You've choosen to convert from {0} to {1}", scales[choice_1 - 1], scales[choice_2 - 1]);
            Console.WriteLine("Now enter the temperature that you want to convert from {0} to {1}", scales[choice_1 - 1], scales[choice_2 - 1]);
            Console.Write("Your input: ");

            // Just some validation of the input
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Sorry, your input was not available");
                Console.Write("Your input: ");
            }

            // This part of the code will call the method and assign the output to the local variable output
            double output = TemperatureMathematics(input, choice_1, choice_2);

            Console.WriteLine("The temperature {0} in {1} is equivalent to the temperature {2} in {3}", input, scales[choice_1 - 1], output, scales[choice_2 - 1]);
        }

        static double TemperatureMathematics(double input, int choice_1, int choice_2)
        {
            // This line calls the TemperatureSetting method, which converts the given temperature to celsius
            // It's easier to convert the temperature to celsius then from any other scale
            // Assigns the returned value to the local variable temperature
            double temperature = TemperatureSetting(input, choice_1);

            // The local variable temperature is then used as parameter of the TemperatureGetting, which will then finally convert the temperature to the choosen scale
            double output = TemperatureGetting(temperature, choice_2);
            return output;
        }

        static double TemperatureSetting(double input, int choice_1)
        {
            // From Celsius
            if (choice_1 == 1)
            {
                C = input;
                return C;
            }

            // From Farenheit
            else if (choice_1 == 2)
            {
                F = input;
                C = (F - 32) / 1.8;
                return C;
            }

            // From Kelvin
            else if (choice_1 == 3)
            {
                K = input;
                C = K - 273.15;
                return C;
            }

            // From Rankine
            else if (choice_1 == 4)
            {
                Ra = input;
                C = (Ra - 491.67) / 1.8;
                return C;
            }

            // From Romer
            else if (choice_1 == 5)
            {
                Ro = input;
                C = (Ro - 7.5) * (40.0 / 21.0);
                return C;
            }

            // From Newton
            else if (choice_1 == 6)
            {
                Ne = input;
                C = Ne / .33;
                return C;
            }

            // From Delisle
            else if (choice_1 == 7)
            {
                De = input;
                C = 100 - (De * (2.0 / 3));
                return C;
            }

            // From Reamur
            else
            {
                Re = input;
                C = Re / .8;
                return Re;
            }

        }

        static double TemperatureGetting(double temperature, int choice_2)
        {
            // To Celsius
            if (choice_2 == 1)
            {
                C = temperature;
                return C;
            }

            // To Farenheit
            else if (choice_2 == 2)
            {
                C = temperature;
                F = 1.8 * C + 32;
                return F;
            }

            // To Kelvin
            else if (choice_2 == 3)
            {
                C = temperature;
                K = C + 273.15;
                return K;
            }

            // To Rankine
            else if (choice_2 == 4)
            {
                C = temperature;
                Ra = 491.67 + 1.8 * C;
                return Ra;
            }

            // To Roemer 
            else if (choice_2 == 5)
            {
                C = temperature;
                Ro = C * (21.0 / 40) + 7.5;
                return Ro;
            }

            // To Newton
            else if (choice_2 == 6)
            {
                C = temperature;
                Ne = C * .33;
                return Ne;
            }

            // To Delisle
            else if (choice_2 == 7)
            {
                C = temperature;
                De = (100 - C) * (3.0 / 2);
                return De;
            }

            // To Reamur
            else
            {
                C = temperature;
                Re = C * .8;
                return Re;
            }

        }
    }
}
