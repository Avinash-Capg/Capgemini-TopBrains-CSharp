using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int[] result = new int[n];
        int left = 1;

        for (int i = 0; i < n; i++)
        {
            result[i] = left;
            left *= nums[i];
        }

        int right = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= right;
            right *= nums[i];
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(result[i]);
            if (i < n - 1)
                Console.Write(" ");
        }
    }
}