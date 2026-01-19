using System;

interface IArea
{
    double GetArea();
}

abstract class Shape : IArea
{
    public abstract double GetArea();
}

class Circle : Shape
{
    double r;

    public Circle(double r)
    {
        this.r = r;
    }

    public override double GetArea()
    {
        return Math.PI * r * r;
    }
}

class Rectangle : Shape
{
    double w;
    double h;

    public Rectangle(double w, double h)
    {
        this.w = w;
        this.h = h;
    }

    public override double GetArea()
    {
        return w * h;
    }
}

class Triangle : Shape
{
    double b;
    double h;

    public Triangle(double b, double h)
    {
        this.b = b;
        this.h = h;
    }

    public override double GetArea()
    {
        return 0.5 * b * h;
    }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double total = 0;

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            Shape s;

            if (parts[0] == "C")
            {
                s = new Circle(double.Parse(parts[1]));
            }
            else if (parts[0] == "R")
            {
                s = new Rectangle(double.Parse(parts[1]), double.Parse(parts[2]));
            }
            else
            {
                s = new Triangle(double.Parse(parts[1]), double.Parse(parts[2]));
            }

            total += s.GetArea();
        }

        total = Math.Round(total, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine(total);
    }
}