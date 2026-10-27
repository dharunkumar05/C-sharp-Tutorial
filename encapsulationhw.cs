
using System;
namespace encapsulationhw;
class Student
{
    private int marks;

    public int Marks
    {
        get
        {
            return marks;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                marks = value;
            }
            else
            {
                Console.WriteLine("Invalid marks!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();

        s1.Marks = 85;

        Console.WriteLine("Student Marks: " + s1.Marks);

        s1.Marks = 150;
        Console.WriteLine("Student Marks: " + s1.Marks);
    }
}
