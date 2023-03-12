using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    private int _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public int Book
    {
        get { return _book; }
    }

    public int Chapter
    {
        get { return _chapter; }
    }

    public int StartVerse
    {
        get { return _startVerse; }
    }

    public int EndVerse
    {
        get { return _endVerse; }
    }

    public Reference(int book, int chapter, int startVerse, int endVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_endVerse != -1)
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
        else
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
    }
}