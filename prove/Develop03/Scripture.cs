using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public Scripture(string text, Reference reference)
    {
        string[] parts = text.Split(' ');
        
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
        _reference = reference;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine();

        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine("\n");
    }

    public void HideWords(Random random)
    {
        int wordsToHide  = 3;
        int hiddenCount = 0;

        while (hiddenCount < wordsToHide && !AllWordsHidden())
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
} 