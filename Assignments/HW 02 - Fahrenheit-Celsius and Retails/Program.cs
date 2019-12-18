using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxes_and_Retails
{
    class Program
    {
        static void Main(string[] args)
        {
            double taxWA, retailPrice, salesTax, finalPrice;
            taxWA = 6.8;
            Console.WriteLine("In the State of Washington you can pay up to {0}% of the retail price as taxes", taxWA);
            //Print on the screen the State of Washington tax
            Console.WriteLine("Insert the Retail Price of the product that you want to buy");
            //Ask the user to put the retail price of the item that he wants to buy
            retailPrice =Math.Round(Convert.ToDouble(Console.ReadLine()),2);
            //Read the input and convert it from a string to a double literal
            //Used the Math.Round to make it more realistic
            salesTax = Math.Round((taxWA * retailPrice) / 100, 2);
            //Calculates the taxes over the retail price
            //Use the Math.Round to make it more realistic
            finalPrice = retailPrice + salesTax;
            //Calculates the final price of the item, which is the retail price plus the sales taxes
            Console.WriteLine("The product costs U${0} and the sales taxes over that price is U${1}",retailPrice,salesTax);
            //Print the Retail Price and the Sales Taxes so the user can see it separately
            Console.WriteLine("Therefore, the final price for that product is U${0}", finalPrice);
            //Gives the final price 

        }
    }
}
