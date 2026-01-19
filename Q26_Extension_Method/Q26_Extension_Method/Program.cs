using System;
using System.Collections.Generic;

static class Extensions
{
    public static string[] DistinctById(this string[] items)
    {
        HashSet<string> seen = new HashSet<string>();
        List<string> result = new List<string>();

        for (int i = 0; i < items.Length; i++)
        {
            string[] parts = items[i].Split(':');
            string id = parts[0];
            string name = parts[1];

            if (!seen.Contains(id))
            {
                seen.Add(id);
                result.Add(name);
            }
        }

        return result.ToArray();
    }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] items = new string[n];

        for (int i = 0; i < n; i++)
        {
            items[i] = Console.ReadLine();
        }

        string[] output = items.DistinctById();

        for (int i = 0; i < output.Length; i++)
        {
            Console.WriteLine(output[i]);
        }
    }
}