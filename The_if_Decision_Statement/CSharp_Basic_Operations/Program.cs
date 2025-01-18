// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// string firstName="Bob";
// int widgetsSold= 77;
// Console.WriteLine(firstName+ " sold "+ widgetsSold+" widgets");

string firstName="Bob";
int widgetsSold= 7;
Console.WriteLine(firstName+ " sold "+ (widgetsSold+7)+" widgets");

// Casting
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

//determine the remainder after integer division
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
// Order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);


Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
// increment operator before and after the value
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
int fahrenheit = 94;
decimal temperatureConversion = (fahrenheit - 32) * 5/9M;
Console.WriteLine($"The temperature is {temperatureConversion}.");