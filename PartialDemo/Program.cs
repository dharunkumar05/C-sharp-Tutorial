using System;

public partial class Partial1
{
    partial void D(string name);

    partial void A(int age)
    {
        if (age > 18)
        {
            Console.WriteLine("Elgible");
        }
        else
        {
            Console.WriteLine("Not Elgible");
        }
    }

    public static void Main()
    {
        Partial1 p = new Partial1();
        p.D("Vj");
        p.A(20);
        p.bachelor();
        Console.WriteLine("Partial1 Main is running");
    }
}
