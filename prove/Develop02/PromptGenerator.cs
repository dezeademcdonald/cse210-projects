public class PromptGenerator
{
    // Create a list of string
    public List<string> _prompt = new List<string>(){"Who was the most intresting person I interacted with today?",
    "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"};

    public PromptGenerator()
    {

    }

    Random random = new Random();

    public string GetRamdomPrompt()
    {
        int randomindex = random.Next(_prompt.Count);
        string randPrompt = _prompt[randomindex];

        return randPrompt;
    }

}