using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int largest;

        if (a >= b && a >= c)
        {
            largest = a;
        }
        else if (b >= a && b >= c)
        {
            largest = b;
        }
        else
        {
            largest = c;
        }

        Console.WriteLine(largest);
    }
}