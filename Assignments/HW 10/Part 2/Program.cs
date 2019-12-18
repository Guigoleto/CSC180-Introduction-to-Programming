using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_10___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the streamwriter class that will write on a file (this case, the input.txt because I'm using it) the information that the user enter
            StreamWriter output = new StreamWriter("input.txt");

            // I'm making the invitation to the user so he can interact with my code 
            Console.Write("If you give me a serie of strings separated by space (each) I can check which one of them are palindromes and print them on the screen: ");

            // This is line of code is reading what is being writen in the console by the user at the same time that it splits each word that is separated by a " " and assigning each word to an array of strings (words)
            string[] input = (Console.ReadLine()).Split();

            // This block is going through each word that was entered by the user and is writing it into the output file (which is the input.txt)
            for (int i = 0; i < input.Length; i++)
            {
                output.WriteLine(input[i]);
            }

            // Closes the StreamWriter and starts to run the code 
            output.Close();

            // Call the DisplayPalidromesFromArray method and feeds it with the value returned by the ReadFileMethod
            DisplayPalindromesFromArray(ReadFile("input.txt"));
        }

        public static string[] ReadFile(string path)
        {
            // Reading all the files and putting them on a string
            string[] arr = File.ReadAllLines(path);

            // Returns the array that was created
            return arr;
        }

        public static bool IsPalindrome(string givenString)
        {
            // Creates two arrays being the first one an array of the characters from the word that was entered 
            char[] x = (givenString.ToUpper()).ToCharArray();
            // This second array is empty and will be filled with same word that was entered but reversed 
            char[] y = new char[x.Length];

            // Creates an index to make the reversion process 
            int index = 0;

            // REVERSE!
            for (int i = x.Length - 1; i >= 0; i--)
            {
                y[index] = x[i];
                index++;
            }

            // Conditional statements that will compare both arrays
            // The SequenceEqual method is the method that is comparing the two arrays to see if they are equal or not, for some reason when I used the "==" I only got false statement 
            if (x.SequenceEqual(y))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static void DisplayPalindromesFromArray(string[] arr)
        {
            //This method is getting the array "arr" and it is testing all the words that are in that array
            Console.WriteLine(); // SkipLine

            for (int i = 0; i < arr.Length; i++)
            {
                // If the statement is true...
                if (IsPalindrome(arr[i]))
                {
                    // print
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}