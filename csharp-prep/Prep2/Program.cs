using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What's your grade percentage?: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        if (gradePercentage >= 90)
        {
            Console.Write("Your grade is A");
        }
        else if (gradePercentage >= 80)
        {
            Console.Write("Your grade is B");
        }
        else if (gradePercentage >= 70)
        {
            Console.Write("Your grade is C");
        }
        else if (gradePercentage >= 60)
        {
            Console.Write("Your grade is D");
        }
        else 
        {
            Console.Write("Your grade is F");
        }
    }
}