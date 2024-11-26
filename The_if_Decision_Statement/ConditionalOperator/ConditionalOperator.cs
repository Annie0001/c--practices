using System;
namespace Variables
{
    class ConditionalOperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ?"boat":"strand of lint";
            Console.Write("You won a");
            Console.Write(message);
            Console.Write(".");
            Console.ReadLine();
        }
    }
}