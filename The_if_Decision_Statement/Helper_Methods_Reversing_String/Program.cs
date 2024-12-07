// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game!");
            ReverseString();
            Console.ReadLine();
        }
        private static void ReverseString()
        {
            string message="Hello World!";
            char [] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
        }
    }
}