using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNum = SquareNumber(userNumber);

        DisplayResult(userName, squareNum);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name?: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number?: ");
        int favoriteNum = int.Parse(Console.ReadLine());
        return favoriteNum;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"Brother {userName}, the square of your favorite number is {square}.");
    }

}