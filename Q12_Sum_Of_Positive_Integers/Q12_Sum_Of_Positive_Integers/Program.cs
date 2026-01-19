using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(Console.ReadLine());

            if (value == 0)
                break;

            if (value < 0)
                continue;

            sum += value;
        }

        Console.WriteLine(sum);
    }
}