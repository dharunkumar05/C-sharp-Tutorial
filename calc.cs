using System;

class Calculator
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static double Divide(int a, int b)
    {
        return (double)a / b;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result: " + Add(a, b));
                break;

            case 2:
                Console.WriteLine("Result: " + Subtract(a, b));
                break;

            case 3:
                Console.WriteLine("Result: " + Multiply(a, b));
                break;

            case 4:
                if (b != 0)
                {
                    Console.WriteLine("Result: " + Divide(a, b));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}