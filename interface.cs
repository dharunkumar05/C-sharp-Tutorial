using System;

interface Geometry
{
    void Area();

    void Perimeter();
}

class Circle : Geometry
{
    public void Area()
    {
        Console.WriteLine("pi*radius^2");
    }

    public void Perimeter()
    {
        Console.WriteLine("2 times pi*radius ");
    }
}

class Square : Geometry
{
    public void Area()
    {
        Console.WriteLine("square of sides");
    }

    public void Perimeter()
    {
        Console.WriteLine("4 times the side");
    }
}

class Shape
{
    public static void Main()
    {
        Console.WriteLine("Circle:");
        Circle c = new Circle();
        c.Perimeter();
        c.Area();
        Console.WriteLine("square:");
        Square s = new Square();
        s.Area();
        s.Perimeter();
    }
}