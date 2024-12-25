// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*string firstFriend = "Maria";
string secondFriend = "Scott";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");*/

string greeting = " Hello World! ";
Console.WriteLine($"[{greeting}]");
// Console.WriteLine("-------------------");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
// Console.WriteLine("-------------------");

trimmedGreeting=greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
// Console.WriteLine("----------------------");

trimmedGreeting=greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

string firstFriend = "Maria";
string secondFriend = "Scott";
string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";
Console.WriteLine(friends.Replace("Scott","Bob"));

Console.WriteLine("*********************************");
Console.WriteLine("*********************************");

firstFriend = "Maria";
secondFriend = "Scott";
friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";

Console.WriteLine(friends);
Console.WriteLine(friends.Replace("Scott","Bob"));
Console.WriteLine(friends);

Console.WriteLine("+++++++++++++++++++++++++++++++++");
Console.WriteLine("+++++++++++++++++++++++++++++++++");

firstFriend = "Maria";
secondFriend = "Scott";
friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";

Console.WriteLine(friends);
friends = friends.Replace("Scott","Bob");
Console.WriteLine(friends);