﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hvordan er vejret udenfor?");
string vejr = Console.ReadLine();
Console.Clear();

Console.WriteLine("Hvor mange grader er det?");
int grader = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine($"Det er {vejr} og {grader} grader udenfor");

