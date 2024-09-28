using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        Entry entry = new Entry();
        entry.Display();
    }

    public void SaveToFile(string file)
    {
        foreach (Entry e in _entries)
        {
            string fileName = "";
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(e);
            }
        }

    }

    public void LoadFrom(string file)
    {
        string fileName = "";
        string[] _entries = System.IO.File.ReadAllLines(fileName);

        foreach (string item in _entries)
        {
            string[] parts = item.Split(" ");

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
        }
    }
}