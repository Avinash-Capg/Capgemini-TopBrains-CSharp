using System;

class Program
{
    static void Main()
    {
        int balance = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int transaction = int.Parse(Console.ReadLine());

            if (transaction >= 0)
            {
                balance += transaction;
            }
            else
            {
                if (balance + transaction >= 0)
                {
                    balance += transaction;
                }
            }
        }

        Console.WriteLine(balance);
    }
}