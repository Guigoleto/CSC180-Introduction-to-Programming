using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace HW_08___Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // I'm creating the random parameters of the Rectangle
            Random random_generator = new Random();

            // I'm creating the variables x,y,w,h to set the X, Y, Weigth and Heigth
            int x, y, w, h;
            // I'm assigning the random numbers generated with the generators below
            x = random_generator.Next(1, 10); // X
            y = random_generator.Next(1, 10); // Y
            w = random_generator.Next(1, 10); // Width
            h = random_generator.Next(1, 10); // Height

            // I'm assigning the values that were created with the random number generators
            Rectangle rec1 = new Rectangle(x, y, w, h);
            Console.WriteLine("\nThe original rectangle has the following dimensions:");
            Console.WriteLine("Upper Left Corner (Origin) in (X= {0}, Y = {1})", rec1.X, rec1.Y);
            Console.WriteLine("Width = {0} and Height = {1}", rec1.Width, rec1.Height);

            // I don't know a better way of returning the values of the FlipRectangle Method other than this way... 
            Rectangle rec2 = new Rectangle(FlipRectangle(rec1).X, FlipRectangle(rec1).Y, FlipRectangle(rec1).Width, FlipRectangle(rec1).Height);

            Console.WriteLine("\nThe new rectangle has the following dimensions:");
            Console.WriteLine("Upper Left Corner (Origin) in (X= {0}, Y = {1})", rec2.X, rec2.Y);
            Console.WriteLine("Width = {0} and Height = {1} \n", rec2.Width, rec2.Height);

            if (IsASquare(rec1))
            {
                Console.WriteLine("Is square");
            }
            else
            {
                Console.WriteLine("Is rectangle");
            }
        }

        static Rectangle FlipRectangle (Rectangle rec1)
        {
            Rectangle rec2 = new Rectangle(rec1.X, rec1.Y, rec1.Height,rec1.Width);
            return rec2;
        }

        // This method is using a rectangle as parameters and if the condition is matched it returns a true value, otherwise it returns a false value which is later used on the if condition to print on the screen if the rectangle is a Square or Not
        static bool IsASquare (Rectangle rec1)
        {
            if(rec1.Width==rec1.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
