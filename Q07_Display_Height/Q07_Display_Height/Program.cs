using System;

class Program
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        string result;

        if (height < 150)
        {
            result = "Short";
        }
        else if (height < 180)
        {
            result = "Average";
        }
        else
        {
            result = "Tall";
        }

        Console.WriteLine(result);
    }
}