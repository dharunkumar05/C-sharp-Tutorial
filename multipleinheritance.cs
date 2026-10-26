using System;

interface INetflix
{
    void WatchNetflix();
}

interface IPrime
{
    void WatchPrime();
}

interface IJioHotstar
{
    void WatchJioHotstar();
}

class OTT : INetflix, IPrime, IJioHotstar
{
    public void WatchNetflix()
    {
        Console.WriteLine("Watching Netflix");
    }

    public void WatchPrime()
    {
        Console.WriteLine("Watching Amazon Prime");
    }

    public void WatchJioHotstar()
    {
        Console.WriteLine("Watching JioHotstar");
    }
}

class Program
{
    static void Main()
    {
        OTT obj = new OTT();

        obj.WatchNetflix();
        obj.WatchPrime();
        obj.WatchJioHotstar();
    }
}