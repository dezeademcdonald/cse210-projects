using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }

    public class Entry
    {
        public DateTime _dates;
        public string _entryText;
        public string _promptText;

        public void Display()
        {
            Console.Write($"Dates: {_dates.ToShortDateString()}\nPrompt: {_promptText}\nEntrytext: {_entryText}");
        }
    }

    public class PromptGenerator
    {

        public List<string> _prompt = new List<string>{
            "1. What did you change your mind about today?", "2. What act of service did you participate in today?",
            "3. How did you build your testimony today?", "4. How did feel the Holy Gohst today?",
            "5. what are your summer activities?"
        };
    }

    public class Journal
    {

        Entry _entries = new Entry();
        PromptGenerator _prompt = new PromptGenerator();

        public void AddEntry()
        {
            Console.WriteLine(_prompt);
            string textEntry = Console.ReadLine();
            Entry entry = new Entry();
            _entries.Add(entry);
        }

        public void DisplayJournal()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

}