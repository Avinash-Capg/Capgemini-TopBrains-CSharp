using System;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        string[] parts = expression.Split(' ');

        if (parts.Length != 3)
        {
            Console.WriteLine("Error:InvalidExpression");
            return;
        }

        int a, b;

        if (!int.TryParse(parts[0], out a) || !int.TryParse(parts[2], out b))
        {
            Console.WriteLine("Error:InvalidNumber");
            return;
        }

        string op = parts[1];

        if (op == "+")
        {
            Console.WriteLine((a + b).ToString());
        }
        else if (op == "-")
        {
            Console.WriteLine((a - b).ToString());
        }
        else if (op == "*")
        {
            Console.WriteLine((a * b).ToString());
        }
        else if (op == "/")
        {
            if (b == 0)
            {
                Console.WriteLine("Error:DivideByZero");
            }
            else
            {
                Console.WriteLine((a / b).ToString());
            }
        }
        else
        {
            Console.WriteLine("Error:UnknownOperator");
        }
    }
}