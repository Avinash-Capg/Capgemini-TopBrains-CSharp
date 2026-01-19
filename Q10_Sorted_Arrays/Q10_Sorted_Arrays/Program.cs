using System;

class Program
{
    static T[] MergeArrays<T>(T[] a, T[] b) where T : IComparable<T>
    {
        T[] result = new T[a.Length + b.Length];
        int i = 0, j = 0, k = 0;

        while (i < a.Length && j < b.Length)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                result[k] = a[i];
                i++;
            }
            else
            {
                result[k] = b[j];
                j++;
            }
            k++;
        }

        while (i < a.Length)
        {
            result[k] = a[i];
            i++;
            k++;
        }

        while (j < b.Length)
        {
            result[k] = b[j];
            j++;
            k++;
        }

        return result;
    }

    static void Main()
    {
        int[] a = { 1, 3, 5, 7 };
        int[] b = { 2, 4, 6, 8 };

        int[] merged = MergeArrays(a, b);

        for (int i = 0; i < merged.Length; i++)
        {
            Console.Write(merged[i]);
            if (i < merged.Length - 1)
                Console.Write(" ");
        }
    }
}