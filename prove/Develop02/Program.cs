using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcom to the program!");
        int optionNum = 0;

        do
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to select? ");
            string option = Console.ReadLine();
            optionNum = int.Parse(option);
            if (optionNum == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                Console.WriteLine(prompt.GetRamdomPrompt());

                Console.Write("");
                string answer = Console.ReadLine();

                Entry entry = new Entry();
                Journal journal = new Journal();

                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                journal.AddEntry(entry);

                entry._promptText = prompt.GetRamdomPrompt();
                journal.AddEntry(entry);

                entry._entryText = answer;
                journal.AddEntry(entry);

            }
            else if (optionNum == 2)
            {

                Journal journal = new Journal();
                journal.Display();

            }
            else if (optionNum == 3)
            {

            }
            else if (optionNum == 4)
            {

            }
            else if (optionNum == 5)
            {
                Console.WriteLine("Your journal closed. Goodby!!");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        } while (optionNum != 5);

    }
}