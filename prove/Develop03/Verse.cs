using System;
using System.Collections.Generic;
using System.Linq;

public class Verse
{
    private int _number;
    private string _text;

    public int Number
    {
        get { return _number; }
    }

    public string Text
    {
        get { return _text; }
    }

    public Verse(int number, string text)
    {
        _number = number;
        _text = text;
    }

    public override string ToString()
    {
        return _text;
    }
}