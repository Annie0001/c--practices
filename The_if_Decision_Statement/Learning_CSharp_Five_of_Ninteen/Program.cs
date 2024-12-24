// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string firstFriend = "Maria";
// string secondFriend = "Scott";
// Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

string greeting = " Hello World! ";
Console.WriteLine($"[{greeting}]");
Console.WriteLine("-------------------");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
Console.WriteLine("-------------------");

trimmedGreeting=greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
Console.WriteLine("----------------------");

trimmedGreeting=greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");