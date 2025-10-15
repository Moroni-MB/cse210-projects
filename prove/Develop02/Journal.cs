using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(string text, string date, string prompt)
    {
        Entry newEntry = new Entry();
        newEntry._prompt = prompt;
        newEntry._text = text;
        newEntry._date = date;
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.GetFullEntry();
            }
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add($"{entry._date}|{entry._prompt}|{entry._text}");
        }

        File.AppendAllLines(filename, lines);
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._prompt = parts[1];
                    entry._text = parts[2];
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}