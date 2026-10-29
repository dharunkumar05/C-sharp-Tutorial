using System;
using System.Text;

class Sb
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");
        int s = sb.Capacity;
        Console.WriteLine(sb + "," + s);
        sb.Append("abcdefefefes");
        s = sb.Capacity;
        Console.WriteLine(s);
        sb.Remove(2, 16);
        Console.WriteLine(sb);

    }
}
