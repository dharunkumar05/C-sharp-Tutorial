using System;

public class Test
{
    public void test1()
    {
        Console.WriteLine("Public modifier");
    }
    private void test2()
    {
        Console.WriteLine("Private modifier");
    }
    protected void test3()
    {
        Console.WriteLine("protected modifier");
    }
    internal void test4()
    {
        Console.WriteLine("internal modifier");
    }
    internal protected void test5()
    {
        Console.WriteLine("internal protected modifier");
    }

}
