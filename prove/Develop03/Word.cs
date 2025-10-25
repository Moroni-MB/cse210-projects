using System;

public class Word
{
    private string _word;
    private bool _hidden;
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public void Hide()
    {
        _hidden = true;
    }
    public void UnHide()
    {
        _hidden = false;
    }
    public string Display()
    {
        if (_hidden)
        {
            string hiddenWord = "";
            foreach (char c in _word)
            {
                hiddenWord += char.IsLetter(c)?"_": c;
            }
            return hiddenWord;
        }
        else
        {
            return _word;
        }
    }
    public bool IsHidden()
    {
        return _hidden;
    }
}