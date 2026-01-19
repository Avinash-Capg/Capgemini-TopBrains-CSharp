using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (input != "null")
            {
                double value = double.Parse(input);
                sum += value;
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("null");
        }
        else
        {
            double avg = sum / count;
            avg = Math.Round(avg, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine(avg);
        }
    }
}