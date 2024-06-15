using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine();

        Console.Write("What is your first name? ");
        string FirstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string LastName = Console.ReadLine();

        Console.Write($"Your full name is {LastName}, {FirstName} {LastName}.");
    }
}