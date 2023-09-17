using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int mNum = randomGenerator.Next(1, 100);

        
        int gNum = 0;
        

        while (gNum != mNum)
        {
            Console.Write("What's the guess number?: ");
            string userInput = Console.ReadLine();
            gNum = int.Parse(userInput);

            if (mNum > gNum)
            {
                Console.WriteLine("Higher");
            }
            else if (mNum < gNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            Console.ReadLine();
        }
        
    }
}