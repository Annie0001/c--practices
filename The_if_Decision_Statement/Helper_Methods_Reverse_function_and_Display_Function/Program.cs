// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace Helper_Methods_Reverse_function_and_Display_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name?");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name?");
            string lastName = Console.ReadLine();
            
            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            Console.Write("Results:");
            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);

            DisplayResult(reversedFirstName, reversedLastName, reversedCity);
            Console.ReadLine();

        }
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }
        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}", reversedFirstName,reversedLastName,reversedCity));
            
        }
    }
}