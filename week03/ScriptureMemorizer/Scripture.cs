using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string part in parts)
        {
            string clean = part.Trim(',', '.', ';', ':', '!', '?', '"');
            Word w = new Word(clean);
            _words.Add(w);

            if (clean.Length > 0)
                _words.Add(new Word(clean));

        }

    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }

        return result.TrimEnd();
    }

    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
