using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int inputNumber = -1;
        int sum = 0;

        do
        {
            Console.Write("Enter a number and type 0 to quit when finished: ");

            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        } while (inputNumber != 0);

        // Calculating the sum
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The is sum: {sum}");

        // Calculating the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // calculating the max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}