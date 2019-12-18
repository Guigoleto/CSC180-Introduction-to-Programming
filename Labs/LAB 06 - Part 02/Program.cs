using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_07
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter outFile = new StreamWriter("output.txt"); // This is the statement that allows me to write an output the file 
            StreamReader inFile = new StreamReader("input.txt"); // This is the statement that allows me to read the input file         string line = inFile.ReadLine();
            int counter = 0; //Sets the counter to 0
            string line = inFile.ReadLine(); // Creates the string line that will read the inFile lines 
            while (line != null) // This statement will read the file until there are no lines left (the "blank" lines also counts as lines)
            {
                counter++; // COUNTS UPPP
                Console.Write(counter); // This statement and the statement in line 23 makes the formating that was asked  
                outFile.Write(counter); // This statement and the statments that begins with the "outFile" will write the same lines in the output file
                Console.Write(" ");
                outFile.Write(" ");
                Console.WriteLine(line); // Displays the line
                outFile.WriteLine(line);
                line = inFile.ReadLine(); // Read the line 
            }

            Console.WriteLine("\n{0} lines were copied from input.txt into output.txt\n", counter); // Says how many lines were copied, see that as I haven't made a copy of it to the output file it will be printed on the console but not the output file
            inFile.Close(); //Stops reading the input
            outFile.Close(); //Stops writing the output

        }

    }
}