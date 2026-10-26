using System;
namespace methodoverloading;
class Program
{

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }


    static double Add(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine(Add(10, 20));
        Console.WriteLine(Add(10, 20, 30));
        Console.WriteLine(Add(10.5, 20.5));
    }
}