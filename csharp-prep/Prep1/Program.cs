using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.ReadLine();

        Console.Write("What's your first name?: ");
        string firstName = Console.ReadLine();

        Console.Write("What's your last name?: ");
        string lastName = Console.ReadLine();

        Console.ReadLine();

        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");

        Console.ReadLine();
    }
    
}