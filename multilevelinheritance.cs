using System;

class Dept
{
    public string deptName = "CSE";

    public void DisplayDept()
    {
        Console.WriteLine("Department: " + deptName);
    }
}

class Staff : Dept
{
    public int staffID = 111;

    public void DisplayStaff()
    {
        Console.WriteLine("Staff ID: " + staffID);
    }
}

class Stud : Staff
{
    public string studentName = "Dharun";

    public void DisplayStud()
    {
        Console.WriteLine("Student Name: " + studentName);
    }
}

class Inheritance
{
    public static void Main()
    {
        Stud s = new Stud();

        s.DisplayStud();
        s.DisplayStaff();
        s.DisplayDept();
    }
}