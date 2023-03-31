using System;

interface IFigure
{
    double GetArea();
}

class Circle : IFigure
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Triangle : IFigure
{
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetArea()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public bool IsRightAngled()
    {
        double[] sides = new double[] { a, b, c };
        Array.Sort(sides);
        return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Triangle triangle = new Triangle(3, 4, 5);

        Console.WriteLine("Circle area: " + circle.GetArea());
        Console.WriteLine("Triangle area: " + triangle.GetArea());
        Console.WriteLine("Triangle is right-angled: " + triangle.IsRightAngled());
    }
}