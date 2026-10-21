
using System;

class NumberAnalyzer
{
    static void Main()
    {
        int[] numbers = new int[8];
        int count = 0;


        while (count < 8)
        {
            Console.Write($"Enter integer {count + 1}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                numbers[count] = number;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter an integer.");
            }
        }

        int even = 0, odd = 0;
        int positive = 0, negative = 0, zero = 0;

        foreach (int n in numbers)
        {
            if (n % 2 == 0)
                even++;
            else
                odd++;

            if (n > 0)
                positive++;
            else if (n < 0)
                negative++;
            else
                zero++;
        }

        Console.WriteLine("\nEven: " + even);
        Console.WriteLine("Odd: " + odd);
        Console.WriteLine("Positive: " + positive);
        Console.WriteLine("Negative: " + negative);
        Console.WriteLine("Zero: " + zero);

        // Find the largest and second-largest distinct values
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        bool hasLargest = false;
        bool hasSecond = false;

        foreach (int n in numbers)
        {
            if (!hasLargest || n > largest)
            {
                if (hasLargest)
                {
                    secondLargest = largest;
                    hasSecond = true;
                }

                largest = n;
                hasLargest = true;
            }
            else if (n < largest &&
                     (!hasSecond || n > secondLargest))
            {
                secondLargest = n;
                hasSecond = true;
            }
        }

        if (hasSecond)
            Console.WriteLine("Second-largest distinct number: " + secondLargest);
        else
            Console.WriteLine("No second-largest distinct number exists.");

        // Reverse the array manually
        Console.Write("Reversed array: ");

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}
