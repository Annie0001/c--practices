// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var scores = new List <int> {97,92,81,60};
// IEnumerable <int> ScoreQuery=
//             from score in scores
//             where score>80
//             orderby score descending
//             select score;

// foreach (int i in ScoreQuery)
// {
//     Console.Write(i+ " ");
// }

IEnumerable <string> ScoreQuery=
            from score in scores
            where score>80
            orderby score descending
            select $"The score is {score}";

foreach (string s in ScoreQuery)
{
    Console.WriteLine(s);
}