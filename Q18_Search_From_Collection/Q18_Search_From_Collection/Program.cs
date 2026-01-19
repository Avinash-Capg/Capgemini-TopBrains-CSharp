using System;
using System.Collections.Generic;

class Program
{
    public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>()
    {
        { "Laptop", 120 },
        { "Mobile", 300 },
        { "Tablet", 80 },
        { "Headphone", 150 }
    };

    public static SortedDictionary<string, long> FindItemDetails(long soldCount)
    {
        SortedDictionary<string, long> result = new SortedDictionary<string, long>();

        foreach (var item in itemDetails)
        {
            if (item.Value >= soldCount)
            {
                result.Add(item.Key, item.Value);
            }
        }

        return result;
    }

    static void Main()
    {
        long soldCount = long.Parse(Console.ReadLine());

        SortedDictionary<string, long> output = FindItemDetails(soldCount);

        foreach (var item in output)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}