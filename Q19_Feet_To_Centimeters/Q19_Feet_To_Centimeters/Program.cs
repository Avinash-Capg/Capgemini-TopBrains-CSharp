using System;

class Program
{
    static void Main()
    {
        int feet = int.Parse(Console.ReadLine());
        double cm = feet * 30.48;
        cm = Math.Round(cm, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine(cm);
    }
}