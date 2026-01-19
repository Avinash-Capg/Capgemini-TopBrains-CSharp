using System;

class Program
{
    static void Main()
    {
        object[] values = new object[]
        {
            10, "abc", 20, true, null, 5.5, 30
        };

        int sum = 0;

        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] is int x)
            {
                sum += x;
            }
        }

        Console.WriteLine(sum);
    }
}