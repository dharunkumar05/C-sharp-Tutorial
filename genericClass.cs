using System;

class Generic<T>
{
    public T team;

    public void name( T team)
    {
        Console.WriteLine(team);
    }
}

class Gen
{
    public static void Main()
    {
        Generic<int> a = new Generic<int>();
        a.team = 123;
        a.name(a.team);


    }
}