using System;

class Program
{
    static void Main()
    {
        const decimal rate = 0.92m;

        decimal usd = decimal.Parse(Console.ReadLine());
        decimal euro = usd * rate;

        euro = Math.Round(euro, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine(euro);
    }
}