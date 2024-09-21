using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int grade = int.Parse(userInput);

        string letter = "";

        string plusSign = "+";
        string minusSign = "-";


        if (grade >= 90)
        {
            if (grade % 10 >= 7)
            {
                letter = $"A{plusSign}";
            }

            else if (grade % 10 <= 3)
            {
                letter = $"A{minusSign}";
            }

            else
            {
                letter = "A";
            }
        }

        else if (grade >= 80)
        {
            if (grade % 10 >= 7)
            {
                letter = $"B{plusSign}";
            }

            else if (grade % 10 <= 3)
            {
                letter = $"B{minusSign}";
            }

            else
            {
                letter = "B";
            }
        }

        else if (grade >= 70)
        {
            if (grade % 10 >= 7)
            {
                letter = $"C{plusSign}";
            }

            else if (grade % 10 <= 3)
            {
                letter = $"C{minusSign}";
            }

            else
            {
                letter = "C";
            }
        }

        else if (grade >= 60)
        {
            if (grade % 10 >= 7)
            {
                letter = $"D{plusSign}";
            }

            else if (grade % 10 <= 3)
            {
                letter = $"D{minusSign}";
            }

            else
            {
                letter = "D";
            }
        }

        else
        {
            if (grade % 10 >= 7)
            {
                letter = $"F{plusSign}";
            }

            else if (grade % 10 <= 3)
            {
                letter = $"F{minusSign}";
            }

            else
            {
                letter = "F";
            }
        }

        Console.WriteLine($"Your grade  is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you pass!");
        }

        else
        {
            Console.WriteLine("Please try again.");
        }
    }
}