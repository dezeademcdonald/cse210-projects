using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNum(userNumber);

        DisplayResult(userName, squaredNumber);

    }

    static void DisplayWelcomMessage()
    {
        Console.WriteLine("Welcom to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name?: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your Favorite number: ");
        int favoritNum = int.Parse(Console.ReadLine());
        return favoritNum;
    }

    static int SquareNum(int favoritNum)
    {
        int squareResult = favoritNum * favoritNum;
        return squareResult;
    }

    static void DisplayResult(string name, int squareResult)
    {
        Console.WriteLine($"{name}, the square of your favorite number is: {squareResult}.");
    }

    

    
}