// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var names = new List <string> {"Ann","Jeff","Bob","Kiki"};
foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("------------------------------");
Console.WriteLine(names[names.Count-1]);

Console.WriteLine("------------------------------");
Console.WriteLine("------------------------------");
Console.WriteLine(names[^1]);

Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
foreach (var name in names[1..3])
{
    Console.WriteLine(name);
}