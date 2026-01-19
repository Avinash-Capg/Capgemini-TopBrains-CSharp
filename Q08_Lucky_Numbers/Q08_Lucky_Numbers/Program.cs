using System;

class Program
{
    static int SumDigits(int x)
    {
        int sum = 0;
        while (x > 0)
        {
            sum += x % 10;
            x /= 10;
        }
        return sum;
    }

    static bool IsPrime(int x)
    {
        if (x <= 1) return false;
        for (int i = 2; i * i <= x; i++)
        {
            if (x % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int count = 0;

        for (int x = m; x <= n; x++)
        {
            if (!IsPrime(x) && x > 0)
            {
                int s1 = SumDigits(x);
                int s2 = SumDigits(x * x);

                if (s2 == s1 * s1)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}