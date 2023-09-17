using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> nums = new List<int>();

        int userInput = -2;
        while (userInput != 0)
        {
            Console.Write("Please enter your numbers. and enter 0 to quit. ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                nums.Add(userInput);
            }
        }

        int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
        
        Console.WriteLine($"The sum of your numbers is: {sum}");

        int max = nums[0];

        foreach(int num in nums)
        {
            if (num > max)
            {
                max = num;
            }
        }
        
        Console.WriteLine($"The maximun is: {max}");
    }
}