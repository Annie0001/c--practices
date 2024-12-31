// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var names = new List<string>{"Annie","Ana","Felipe"};
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine("                               ");
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I have added {names[2]} and {names[3]} to the list.");
Console.WriteLine($"The list has {names.Count} people in it.");
Console.WriteLine("                               ");

Console.WriteLine("--------------------------------------");
Console.WriteLine("--------------------------------------");

// var namess = new List <string>{};
names.Add("Maria");
names.Add("John");
for (int i=0; i<names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("--------------------------------------");
var index = names.IndexOf("Felipe");
if (index != -1)
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}
var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
Console.WriteLine("                               ");
Console.WriteLine("--------------------------------------");

names.Sort();
foreach(var name in names)
{
    // Console.WriteLine($"{name}");
    Console.WriteLine(name);
}




