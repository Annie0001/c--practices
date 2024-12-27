// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int a = 18;
int b = 6;
int c = a + b;
int c1 = a / b;
Console.WriteLine(c);
Console.WriteLine(c1);

Console.WriteLine("_____________________________");
Console.WriteLine("                              ");

int a1 = 5;
int b1 = 4;
int c2 = 2;
int d = (a1 + b1) * c2;
Console.WriteLine(d);

Console.WriteLine("_____________________________");
Console.WriteLine("                              ");

int a2 = 5;
int b2 = 4;
int c3 = 2;
int d1 = (a2 + b2) - 6 * c3 + (12 * 4) / 3 + 12;
Console.WriteLine(d1);

Console.WriteLine("_____________________________");
Console.WriteLine("                              ");

int a3 = 7;
int b3 = 4;
int c4 = 3;
int d2 = (a3 + b3) / c4;
Console.WriteLine(d2);


Console.WriteLine("_____________________________");
Console.WriteLine("                               ");
// You can get the remainder by using the remainder operator, the % character

int a4 = 7;
int b4 = 4;
int c5 = 3;
int d3 = (a4 + b4) / c5;
int e = (a4 + b4) % c5;
Console.WriteLine($"quotient: {d3}");
Console.WriteLine($"remainder: {e}");

Console.WriteLine("_____________________________");
Console.WriteLine("                               ");
int max=int.MaxValue;
int min=int.MinValue;
Console.WriteLine($"The range for integer is {min} to {max}");

Console.WriteLine("_____________________________");
Console.WriteLine("                               ");
//  Double type
double a5 = 5;
double b5 = 4;
double c6 = 2;
double d4 = (a5 + b5) / c6;
Console.WriteLine(d4);

Console.WriteLine("_____________________________");
Console.WriteLine("                               ");
double a6 = 19;
double b6 = 23;
double c7 = 8;
double d5 = (a6 + b6) / c7;
Console.WriteLine(d5);

Console.WriteLine("_____________________________");
Console.WriteLine("                               ");
double max_double=double.MaxValue;
double min_double=double.MinValue;
Console.WriteLine($"The range for double is {min_double} and {max_double}");


Console.WriteLine("_____________________________");
Console.WriteLine("                               ");

double third = 1.0 / 3.0;
Console.WriteLine(third);

Console.WriteLine("_____________________________");
Console.WriteLine("                               ");
// Decimal types

decimal min_Decimal = decimal.MinValue;
decimal max_Decimal = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min_Decimal} to {max_Decimal}");


Console.WriteLine("_____________________________");
Console.WriteLine("                               ");
double a7 = 1.0;
double b7 = 3.0;
Console.WriteLine(a7 / b7);

decimal c8 = 1.0M;
decimal d8 = 3.0M;
Console.WriteLine(c8 / d8);