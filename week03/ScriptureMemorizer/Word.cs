using System;
using System.Collections.Generic;
using System.Linq;
   
public class Word
{
    private string _text;
    private bool _isHidden;
    public bool IsHidden { get{return _isHidden;} private set{_isHidden = value;}}

    public Word(string text)
    {
        _text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public string DisplayText()
    {
        return IsHidden ? new string('_', _text.Length) : _text;
    }
}