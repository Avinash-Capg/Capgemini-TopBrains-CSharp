using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("log.txt");
        StreamWriter writer = new StreamWriter("error.txt");

        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains("ERROR"))
            {
                writer.WriteLine(lines[i]);
            }
        }

        writer.Close();
    }
}