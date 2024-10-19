using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment ass = new Assignment("Jame Brown", "Addition");

        Console.WriteLine(ass.GetSummary());

        MathAssignment math = new MathAssignment("James Brown", "Additon", "7.6", "8-9");

        Console.WriteLine(math.GetHomeWorkList());

        WritingAssignment writing = new WritingAssignment("James Brown", "European History", "The Cause of War World II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInfo());
    }
}