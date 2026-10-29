using System;

public partial class Partial1 : Subject
{
    partial void D(string name)
    {
        Console.WriteLine(name);
    }
    partial void A(int age);

}