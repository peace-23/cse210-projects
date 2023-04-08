using System;
using System.Collections.Generic;
using System.Linq;
public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void ReplaceWithUnderscore()
    {
        _text = new string('_', _text.Length);
    }

    public override string ToString()
    {
        return _text;
    }
}
