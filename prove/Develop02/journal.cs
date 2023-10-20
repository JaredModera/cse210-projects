using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // Entry entry1 = newEntry;
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        string entries = _entries.ToString();
        Console.WriteLine($"Entries: {entries}");
    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {
        
    }
}
