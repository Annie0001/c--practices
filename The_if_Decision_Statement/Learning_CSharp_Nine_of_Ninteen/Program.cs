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

Console.WriteLine("-------------------------------------------");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("                                           ");

int counter1=0;
do{
    Console.WriteLine($"Hello World! The counter is {counter1}");
    counter1++;
}
while (counter1 < 10);

Console.WriteLine("-------------------------------------------");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("                                           ");

for (int counter2=0; counter2 < 10; counter2++)
{
    Console.WriteLine($"Hello World! The counter is {counter2}");
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("                                           ");

for (int row=1 ; row< 11; row++)
{
    for (char column='a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("                                           ");

/*find the sum of all integers 1 through 20 that are divisible by 3. Here are a few hints:
The % operator gives you the remainder of a division operation.
The if statement gives you the condition to see if a number should be part of the sum.
The for loop can help you repeat a series of steps for all the numbers 1 through 20.
Try it yourself. Then check how you did. As a hint, you should get 63 for an answer.*/

int sum=0;
for (int number=1; number< 20; number ++)
{
    if (number % 3 == 0)
    {
        sum = sum + number;
    }
}
Console.WriteLine($"Sum is: {sum}");

Console.WriteLine("----------------------------------------");
Console.WriteLine("----------------------------------------");

int a3=5;
int b3=3;
int c3=4;

if ((a3+b3+c3 > 10)&& (a==b))
{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to second number.");
}
else
{
    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("And the first number is not equal to second number.");
}
