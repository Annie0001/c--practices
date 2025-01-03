// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
var scores = new List<int>{3,45,82,97,92,100,81,60};

// IEnumerable <string> scoreQuery=
//             from score in scores
//             where score>80
//             orderby score descending
//             select $"The score is {score}";

// foreach (string s in scoreQuery)
// {
//     Console.WriteLine(s);
// }

Console.WriteLine("________________________________");
Console.WriteLine("________________________________");

IEnumerable <int> scoreQuery=
            from score in scores
            where score>80
            orderby score descending
            select score;

// To make the list of the scores questioned/queried
// when we changed from string back to int and llist them
// now we have literal list of ints 
List <int> myscores = scoreQuery.ToList();

foreach (var score in myscores)
{
    Console.WriteLine(score);
}


Console.WriteLine("________________________________");
Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
// IEnumerable <string> scoreQuery=
//             from score in scores
//             where score>80
//             orderby score descending
//             select $"The score is {score}";
//                                Line 7
var scoreQuery1 = scores.Where(s =>s > 80).OrderByDescending(s => s);

List <int> myscores1 = scoreQuery1.ToList();

foreach (var score in myscores1)
{
    Console.WriteLine(score);
}