using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // I'm setting the values with the methods SET and GET and I'm using the special methods to display the information
            Car c1 = new Car();
            c1.SetVin("KXB-4857");
            c1.SetFuelLevel(50);
            c1.SetMake("Honda");
            c1.SetModel("HRV");
            c1.SetColor("Gray");
            c1.SetMileage(100);
            c1.Honk();
            Console.WriteLine();
            c1.Drive(24);
            c1.Honk();
            Console.WriteLine();

            // I'm setting the values with the constructor that I created instead of using the SET and GET methods
            Car c2 = new Car("XXT-4869", 20, "Honda", "HRV",  200);
            c2.SetColor("White");
            c2.Honk();
            Console.WriteLine();
            c2.Drive(72);
            c2.Honk();
        }
    }

    class Car
    {
        // Set/Get VIN
        // The objective of making a private variable is to prevent a direct change on that variable on the main method, therefore, creating some sort of "validation" for it
        // As you can see, the Vin doens't have any special condition to work but i'm using a private variable because it was asked and to practice what was seen in class
        private string vin;
        public void SetVin(string someVin)
        {
            // uses the parameter to assign it to the private variable "vin"
            vin = someVin;
        }

        public string GetVin()
        {
            // You can get the vin value using this method
            return vin;
        }

        // Set/Get fuelLevel
        // The objective of making a private variable is to prevent a direct change on that variable on the main method, therefore, creating some sort of "validation" for it
        // As you can see, the fuelLevel doens't have any special condition to work but i'm using a private variable because it was asked and to practice what was seen in class
        private double fuelLevel;
        public void SetFuelLevel(double someFuelLevel)
        {
            fuelLevel = someFuelLevel;
        }

        public double GetFuelLevel()
        {
            return fuelLevel;
        }

        // Set/Get Make
        // The objective of making a private variable is to prevent a direct change on that variable on the main method, therefore, creating some sort of "validation" for it
        // As you can see, the setMake doens't have any special condition to work but i'm using a private variable because it was asked and to practice what was seen in class

        private string make;
        public void SetMake(string someMake)
        {
            make = someMake;
        }

        public string GetMake()
        {
            return make;
        }

        // Set/Get Model
        // The objective of making a private variable is to prevent a direct change on that variable on the main method, therefore, creating some sort of "validation" for it
        // As you can see, the model doens't have any special condition to work but i'm using a private variable because it was asked and to practice what was seen in class
        private string model;
        public void SetModel(string someModel)
        {
            model = someModel;
        }

        public string GetModel()
        {
            return model;
        }

        // Set/Get Color
        // The objective of making a private variable is to prevent a direct change on that variable on the main method, therefore, creating some sort of "validation" for it
        // As you can see, the setcColor doens't have any special condition to work but i'm using a private variable because it was asked and to practice what was seen in class
        private string color;
        public void SetColor(string someColor)
        {
            color = someColor;
        }

        public string GetColor()
        {
            return color;
        }

        // Set/Get Mileage
        // The objective of making a private variable is to prevent a direct change on that variable on the main method, therefore, creating some sort of "validation" for it
        // As you can see, only special condition is that the mileage can't be lower then 0, if a value below 0 is entered, then it set's the mileage as 0
        private int mileage;
        public void SetMileage(int someMileage)
        {
            if (someMileage >=0)
            {
                mileage = someMileage;
            }
            else
            {
                mileage = 0;
            }
        }

        public int GetMileage()
        {
            return mileage;
        }

        // The "special" method Drive, Honk and Add Fuel
        //The method drive reduce the fuel level by 1 for every 24 miles that is the user drives and also increase the mileage by 24
        public void Drive(double miles)
        {
            while(miles >= 24)
            {
                miles -= 24;
                fuelLevel -= 1;
                mileage += 24;
            }
        }

        //This method is just displaying on the screen the same information as the override method by using Console.WriteLine 
        public void Honk ()
        {
            Console.WriteLine("Vehicle Identification Number = {0}", vin);
            Console.WriteLine("Fuel Level = {0}", fuelLevel);
            Console.WriteLine("Mileage = {0}", mileage);
            Console.WriteLine("Vehicle Maker = {0}", make);
            Console.WriteLine("Vehicle Model = {0}", model);
            Console.WriteLine("Vehicle Color = {0}", color);
        }

        public double AddFuel(double fuel)
        {
            fuelLevel += fuel;
            return fuelLevel;
        }

        // First Constructor
        public Car()
        {

        }

        // Second Constructor that require parameters
        // I couldn't think of any creative constructor or different thing to do... so I just made a constructor without parameters
        public Car(string u_vin, double u_fuelLevel, string u_make, string u_model, int u_mileage)
        {
            SetVin(u_vin);
            SetFuelLevel(u_fuelLevel);
            SetMake(u_make);
            SetModel(u_model);
            SetMileage(u_mileage);
        }

        // "Bonus"
        public override string ToString()
        {
            return String.Format("The Vehicle Identification Number is {0}, Car Model is {1} from {2} and its color is {3}. Its mileage was {4} and the tank had {5}", GetVin(), GetModel(), GetMake(), GetColor(), GetMileage(), GetFuelLevel());
        }
    }
}
