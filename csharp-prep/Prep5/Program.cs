using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string inputName = PromptUserName();

        int inputNumber = PromptUserNumber();

        int squareInputNumber = SquareNumber(inputNumber);

        DisplayResult(inputName, squareInputNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What's your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What's your favorite number?");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int num)
    {
        int squareNum = num * num;
        return squareNum;
    }

    static void DisplayResult(string name, int squareNum)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {squareNum}");
    }
}