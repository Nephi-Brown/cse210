using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference ;
        _words = new List<Word>() ;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}: {string.Join(" ", _words.Select(w => w.DisplayText()))}");
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        for (int i = 0; i < Math.Min(numberToHide, visibleWords.Count); i++)
        {
            visibleWords[random.Next(visibleWords.Count)].Hide();
        }
    }

    public bool AllWordsHidden() => _words.All(w => w.IsHidden);
}