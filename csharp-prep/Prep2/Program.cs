using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();
        // Pre 2 assignment starts here
        Console.Write("What is your grade percentages? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine();

        Console.WriteLine($"Your grade is:  {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed");
        }

        else
        {
            Console.WriteLine("You Failed. Please try again");
        }
    }
}