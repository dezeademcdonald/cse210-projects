using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int numToEndWhileLoop = 0;
        int inputNum = -1;
        List<int> listOfNums = new List<int>();

        Console.WriteLine("Enter a list of numbers, Type 0 when finished");

        while (inputNum != numToEndWhileLoop)
        {
            Console.Write("Enter number: ");
            string numEnter = Console.ReadLine();
            inputNum = int.Parse(numEnter);
            listOfNums.Add(inputNum);

            if (inputNum == numToEndWhileLoop)
            {
                Console.WriteLine("The sum is: " + listOfNums.Sum());
                Console.WriteLine("The average is: " + listOfNums.Average());
                Console.WriteLine("The largest number is: " + listOfNums.Max());

                Console.WriteLine("The sorted list is:");
                listOfNums.Sort();

                foreach (int number in listOfNums)
                {
                    Console.WriteLine(number);
                }

            }

        }
    }
}