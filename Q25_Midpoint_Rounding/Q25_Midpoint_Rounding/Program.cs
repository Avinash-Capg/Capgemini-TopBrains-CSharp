using System;

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        area = Math.Round(area, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine(area);
    }
}