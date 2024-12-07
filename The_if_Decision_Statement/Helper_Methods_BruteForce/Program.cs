// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Net.NetworkInformation;

namespace HelperMethods
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("The Name Game");
            
            Console.Write("What's your first name?");
            string firstName = Console.ReadLine();

            Console.Write("What's your Last name?");
            string lastName = Console.ReadLine();

            Console.Write("In What city were you born?");
            string city = Console.ReadLine();

            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);
            
            char[] LastNameArray = lastName.ToCharArray();
            Array.Reverse(LastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result ="";
            foreach(char item in firstNameArray)
            {
                result += item;
            }
            result +=" ";
            foreach(char item in LastNameArray)
            {
                result += item;
            }
            result +=" ";
            foreach(char item in cityArray)
            {
                result += item;
            }
            Console.WriteLine("Results:"+result);
            Console.ReadLine();
        }
    }
}