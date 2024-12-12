// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game!");
            
            Console.Write("What's your first name?");
            string firstName = Console.ReadLine();
            
            Console.Write("What's your Last name?");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            Console.Write("Results:");
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);

            Console.ReadLine();
            
        }
        private static void ReverseString(string message)
        {
            // string message="";
            char [] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
        }
    }
}