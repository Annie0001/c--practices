// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace For_Iteration_With_If_conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {   
                // Console.WriteLine(i);
                if (i==7)
                {
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }
        }
    }
}