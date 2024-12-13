// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Helper_Methods_Reversing_string_Use_Return_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");
            Console.Write("What's your first name?");
            string fristName =Console.ReadLine();

            Console.Write("What's your Last name?");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            string reversedFirstName = ReverseString(fristName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);

            Console.Write(String.Format("{0} {1} {2}",reversedFirstName,reversedLastName,reversedCity));
            Console.ReadLine();
        }

        private static String ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            // foreach(char item in messageArray)
            // {
            //     Console.Write(item);
            // }
            return String.Concat(messageArray);
        }
    }
}