using System;

class Program
{
    int num;
    string name;

    public Program(int num, string name)
    {
        this.num = num; // Using 'this' to refer to the instance variable
        this.name = name; // Using 'this' to refer to the instance variable
    }

    static void Main(string[] args)
    {
        // Create an instance of the Program class
        Program s1 = new Program(5, "Vj");
        Console.WriteLine("Number: " + s1.num + ", Name: " + s1.name);
        s1.num = 10; // Modifying the instance variable
        s1.name = "Ram"; // Modifying the instance variable
        Console.WriteLine("Number: " + s1.num + ", Name: " + s1.name);
    }
}