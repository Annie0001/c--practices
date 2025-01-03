// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//var score = new List <int> [97,92,81,60];
int[] scores =[97,92,81,60];

IEnumerable<int> scoreQuery=
        from score in scores
        where score > 80
        select score;

foreach (var i in scoreQuery)
{
    Console.WriteLine(i+" ");
}
