using System;

public class Entry
{
    public string _text;
    public string _date;
    public string _prompt;

    public void SaveEntry(string prompt, string text)
    {
        // Save their response, the prompt, and the date as an Entry
        _prompt = prompt;
        _text = text;
        _date = DateTime.Now.ToString("MM/dd/yyyy");
    }

    public string GetEntryText()
    {
        return _text;
    }

    public string GetEntryDate()
    {
        return _date;
    }

    public void GetFullEntry()
    {
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_text}\n");
    }
}