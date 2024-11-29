// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace For_Loop_Iteration_On_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]{"Alex","David","Joe","Bob"};
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        Console.ReadLine();
        }
    }
}