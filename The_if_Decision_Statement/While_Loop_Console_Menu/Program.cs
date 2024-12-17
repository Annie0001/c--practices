// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Print list of Option to our users in a form of a Menu
using System;
using System.Runtime.CompilerServices;
namespace WhileLoopConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        private static void MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
            }
            else if (result == "2")
            {
                GuessingGame();
            }
            else if (result == "3")
            {

            }
            else 
            {

            }
        }
        private static void PrintNumbers()
        {
            Console.WriteLine("Print Numbers!");
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.WriteLine("Guessing Game!");
            Console.ReadLine();
        }
    }
}