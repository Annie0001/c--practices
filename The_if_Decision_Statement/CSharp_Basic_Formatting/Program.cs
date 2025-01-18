// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Add Line after 
Console.WriteLine("Hello\nWorld!");

// Add Tab between text
Console.WriteLine("Hello\tWorld!");

//Add Quatation Mark
Console.WriteLine("Hello \"World\"!");

//Add BAckSlash
Console.WriteLine("Hello c:\\hello\\World");
Console.WriteLine("\n");

//Example
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1021\t\tComplete!\n");
Console.WriteLine("Outpu Directory:\t");

// Verbatim string literal --- Meaning exactly word by word
// A verbatim string literal will keep all whitespace 
// and characters without the need to escape the backslash.
Console.WriteLine(@"     c:\source\repos
        (this is where your code goes)");

// Output: C:\Output\First-Project\Data
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// Exercise
string projectNamee = "ACME";
string passage = $@"c:\Exercise\{projectNamee}\data.txt";
Console.WriteLine($"View English output:\n\t\t{passage}");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string passage1=$@"c:\Exercise\{projectNamee}\ru-RU\data.txt";
Console.WriteLine($"russianMessage:\n\t\t{passage1}");
