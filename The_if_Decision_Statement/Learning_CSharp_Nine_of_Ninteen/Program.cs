// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int a = 5;
int b = 3;
// int b = 6;
if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10.");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("                                           ");

int a1 = 5;
int b1 = 3;
int c1 = 4;
if ((a1 + b1 + c1 > 10) && (a1 == b1))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("                                           ");
int a2 = 5;
int b2 = 3;
int c2 = 4;
if ((a2 + b2 + c2 > 10) || (a2 == b2))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}
Console.WriteLine("-------------------------------------------");
Console.WriteLine("                                           ");

int counter=0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}