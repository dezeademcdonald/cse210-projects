using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Random randomNum = new Random();
        int magicNumber = randomNum.Next(1, 20);
        int userResponse = 0;
        List<int> numOfGuess = new List<int>();

        while (userResponse != magicNumber)
        {

            Console.Write("What is the magic nunber? ");
            string userInput = Console.ReadLine();

            userResponse = int.Parse(userInput);

            numOfGuess.Add(userResponse);

            if (userResponse > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (userResponse < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guess it right!");
            }

            if (userResponse == magicNumber)
            {
                Console.WriteLine($"Your number of guess = {numOfGuess.Count}");

                Console.WriteLine();

                Console.Write("Do you want to play again? ");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (userResponse == magicNumber && answer == "yes")
                {
                    userResponse = 0;
                }

                else if (userResponse == magicNumber && answer == "no")
                {
                    Console.WriteLine("GAME END!");
                }

                else
                {
                    Console.WriteLine("Invalid Selection");
                }

            }

        }

    }
}