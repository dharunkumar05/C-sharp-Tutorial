using System;

class Staff
{
    public string name = "Aka";
    public string subject = "DSA";

    public void DisplayStaff()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Subject: " + subject);
    }
}

class Stud : Staff
{
    public string department = "CSE";
    public int mark = 90;

    public void DisplayStudent()
    {
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Mark: " + mark);
    }

    public static void Main()
    {
        Stud obj = new Stud();

        obj.DisplayStaff();
        obj.DisplayStudent();
    }
}