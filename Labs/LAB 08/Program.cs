using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LAB_08___Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand_generator = new Random();
            // Creates random coordinates for the upper left corner of the first rectangle
            int x_r1 = rand_generator.Next(0, 10);
            int y_r1 = rand_generator.Next(0, 10);
            // Creates random coordinates for the upper left corner of the second rectangle
            int x_r2 = rand_generator.Next(10, 20);
            int y_r2 = rand_generator.Next(10, 20);
            // To be honest it doesn't interfer on the problem itself, what I did here is for practicing and for further use of this code

            Console.WriteLine("If you give me the width and the height of two rectangle, I can calculate its area");
            Console.Write("First, give me the width of the first rectangle: ");
            int width_r1;
            while(!int.TryParse(Console.ReadLine(), out width_r1))
            {
                Console.WriteLine("Sorry your input is not valid");
                Console.Write("First, give me the width of the first rectangle: ");
            }

            Console.Write("Now, give me the height of the first rectangle: ");
            int height_r1;
            while (!int.TryParse(Console.ReadLine(), out height_r1))
            {
                Console.WriteLine("Sorry your input is not valid");
                Console.Write("First, give me the height of the first rectangle: ");
            }

            Rectangle firstRec = new Rectangle(x_r1,y_r1, width_r1,height_r1);

            Console.Write("now, give me the width of the second rectangle: ");
            int width_r2;
            while (!int.TryParse(Console.ReadLine(), out width_r2))
            {
                Console.WriteLine("Sorry your input is not valid");
                Console.Write("First, give me the width of the second rectangle: ");
            }

            Console.Write("Now, give me the height of the second rectangle: ");
            int height_r2;
            while (!int.TryParse(Console.ReadLine(), out height_r2))
            {
                Console.WriteLine("Sorry your input is not valid");
                Console.Write("First, give me the height of the second rectangle: ");
            }

            Rectangle secondRec = new Rectangle(x_r2, y_r2, width_r2, height_r2);

            Console.WriteLine("The area of the first rectangle is {0}",ComputeRectangleArea(firstRec));
            Console.WriteLine("The area of the second rectangle is {0}", ComputeRectangleArea(secondRec));

        }
        
        static double ComputeRectangleArea (Rectangle r)
        {
            double area = r.Width * r.Height;
            return area;
        }
    }
}
