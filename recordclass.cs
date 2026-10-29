using System;
namespace RecordClass;
record class Student(string Name, int Mark)
{
    public string dept  ;

}

class Program
{
    static void Main()
    {
        Student s1 = new("Dharun", 95);

        Student s2 = s1 with { Mark = 100 };
        s2.dept = "mech";

        Student s3 =  new Student( "Ak" , 90)
        {
            dept = "cse"
        };

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
    }
}