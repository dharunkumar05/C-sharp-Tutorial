using System;

class Student
{
    int id;
    string name;
    int age;

    public Student()
    {
        id = 0;
        name = "Un";
        age = 0;
    }

    public Student(int id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }

    public Student(Student s)
    {
        id = s.id;
        name = s.name;
        age = s.age;
    }

    static Student()
    {
        Console.WriteLine("Static constructor called");
    }

    private Student(string name)
    {
        this.name = name;
        id = 0;
        age = 0;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
    }

    static void Main()
    {
        Student s1 = new Student();
        s1.Display();

        Student s2 = new Student(101, "Dharun", 21);
        s2.Display();

        Student s3 = new Student(s2);
        s3.Display();

        Student s4 = new Student("Private Constructor");
        s4.Display();
    }
}