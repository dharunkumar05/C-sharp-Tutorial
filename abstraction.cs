using System;
namespace abstraction;
abstract class Staff
{
    public abstract void Teaching();

    public abstract void Assignemnt();

    public abstract void Test();
}

class CSEStaffs : Staff
{
    public override void Teaching()
    {
        Console.WriteLine("Teaches OOPs");
    }

    public override void Test()
    {
        Console.WriteLine("Test on CN");
    }

    public override void Assignemnt()
    {
        Console.WriteLine("Assignment on DSA");
    }
}
class Mech : Staff
{
    public override void Assignemnt()
    {
        Console.WriteLine("Engineering Graphics");
    }

    public override void Test()
    {
        Console.WriteLine("Test on Welding");
    }

    public override void Teaching()
    {
        Console.WriteLine("Topic on CAD");
    }
}
class Abstraction
{
    public static void Main()
    {
        CSEStaffs a = new CSEStaffs();
        Console.WriteLine("CSE Dept:");
        a.Assignemnt();
        a.Test();
        a.Teaching();
        Console.WriteLine("\n");

        Mech b = new Mech();
        Console.WriteLine("Mechanical Dept:");
        b.Test();
        b.Teaching();
        b.Assignemnt();

    }
}

