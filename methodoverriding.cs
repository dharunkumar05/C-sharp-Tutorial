using System;

class Plumber
{
    public virtual void Work()
    {
        Console.WriteLine("Plumber repairs water pipes");
    }
}

class Electrician : Plumber
{
    public override void Work()
    {
        Console.WriteLine("Electrician repairs electrical wiring");
    }
}

class Program
{
    static void Main()
    {
        Plumber p = new Plumber();
        p.Work();

        Plumber p1 = new Electrician();
        p1.Work();
    }
}