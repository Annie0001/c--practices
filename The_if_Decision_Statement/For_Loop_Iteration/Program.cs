// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace For_Loop_Iteration
{
    class ForLoopIteration
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {4,8,15,16,23,42};
            // foreach ( int number in numbers)
            // {
            //     Console.WriteLine(number);
            // }
            for (int i=0; i<=numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        Console.ReadLine();
        }
    }
}