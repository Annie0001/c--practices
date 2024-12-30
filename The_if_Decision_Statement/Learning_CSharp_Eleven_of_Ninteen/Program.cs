// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int counter=0;
while (counter<10)
{
    Console.WriteLine(counter);
    counter++;
}

Console.WriteLine("-----------------------------");
Console.WriteLine("                             ");

// Nested For Loops for Matrix
for (int row=1; row<11 ; row++)
{
    for (char column='a'; column< 'k'; column++)
    {
        Console.WriteLine($"The cells are ({row},{column})");
    }
}
    