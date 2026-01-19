using System;

class Program
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        string temp = "";
        string result = "";


        for (int i = 0; i < s1.Length; i++)
        {
            char c = s1[i];
            char lowerC = char.ToLower(c);
            bool isVowel = lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
            bool found = false;

            for (int j = 0; j < s2.Length; j++)
            {
                if (lowerC == char.ToLower(s2[j]))
                {
                    found = true;
                    break;
                }
            }

            if (isVowel || !found)
            {
                temp += c;
            }
        }

       
        for (int i = 0; i < temp.Length; i++)
        {
            if (i == 0 || temp[i] != temp[i - 1])
            {
                result += temp[i];
            }
        }

        Console.WriteLine(result);
    }
}