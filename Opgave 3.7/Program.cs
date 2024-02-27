// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hvordan er vejret udenfor?");
var vejr = Console.ReadLine();
Console.Clear();

Console.WriteLine("Hvor mange grader er det udenfor?");
int grader = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine($"Det er {vejr} og {grader} grader udenfor");

