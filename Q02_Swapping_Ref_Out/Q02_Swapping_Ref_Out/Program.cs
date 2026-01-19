using System;

class Program
{
    static void SwapRef(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void SwapOut(int a, int b, out int x, out int y)
    {
        x = b;
        y = a;
    }

    static void Main()
    {
        int n1 = 10;
        int n2 = 20;

        Console.WriteLine("Before swap using ref");
        Console.WriteLine("n1 = " + n1 + ", n2 = " + n2);

        SwapRef(ref n1, ref n2);

        Console.WriteLine("After swap using ref");
        Console.WriteLine("n1 = " + n1 + ", n2 = " + n2);

        int a = 30;
        int b = 40;
        int x, y;

        Console.WriteLine("\nBefore swap using out");
        Console.WriteLine("a = " + a + ", b = " + b);

        SwapOut(a, b, out x, out y);

        Console.WriteLine("After swap using out");
        Console.WriteLine("a = " + x + ", b = " + y);
    }
}