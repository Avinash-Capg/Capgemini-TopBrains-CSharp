using System;

class Program
{
    static void Main()
    {
        decimal radius = decimal.Parse(Console.ReadLine());
        decimal pi = 3.1415926535897932384626433m;
        decimal area = pi * radius * radius;
        area = Math.Round(area, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine(area);
    }
}