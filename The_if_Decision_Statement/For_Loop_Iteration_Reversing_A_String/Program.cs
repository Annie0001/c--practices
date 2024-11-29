// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace For_Loop_Iteration_Reversing_A_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "You can get what you want out of life";
            //It will take the string and with the help of helper method ToCharrArray will chop up
            // the string into array of characters
            char[] charArray = sentence.ToCharArray();
            // Using Utility Methodes to Swap All the Items in the Array
            Array.Reverse(charArray);
            foreach (char character in charArray)
            {
                Console.Write(character);
            }
            Console.ReadLine();
        }
    }
}