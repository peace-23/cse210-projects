using System;
using System.Collections.Generic;
using System.Linq;

class ScriptureRange
{
    public Scripture StartVerse { get; private set; }
    public Scripture EndVerse { get; private set; }

    public ScriptureRange(string startReference, string endReference, string[] verses)
    {
        StartVerse = new Scripture(startReference, verses);
        EndVerse = new Scripture(endReference, verses);
    }

    public string[] GetAllVerses()
    {
        return StartVerse.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

    public int NumHiddenWords()
    {
        return StartVerse.NumHiddenWords() + EndVerse.NumHiddenWords();
    }

    public bool HideRandomWord()
    {
        if (StartVerse.HideRandomWord())
        {
            return true;
        }
        return EndVerse.HideRandomWord();
    }

    public string GetVisibleText()
    {
        return $"{StartVerse.GetVisibleText()} ... {EndVerse.GetVisibleText()}";
    }

    public override string ToString()
    {
        return $"{StartVerse.Reference} - {EndVerse.Reference}: {GetVisibleText()}";
    }
}





