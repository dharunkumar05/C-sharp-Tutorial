
using System;
namespace abstractionhw;
abstract class Employee
{
    public string Name;
    public int Id;

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
    }

    public abstract void CalculateSalary();
}

class Manager : Employee
{
    public Manager(string name, int id) : base(name, id)
    {
    }

    public override void CalculateSalary()
    {
        Console.WriteLine("Salary: 50000");
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Manager("Dharun", 101);

        e.DisplayDetails();
        e.CalculateSalary();
    }
}
