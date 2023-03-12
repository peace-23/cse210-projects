using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _reference;
    private List<Verse> _verses;

    public string Reference
    {
        get { return _reference; }
    }

    public List<Verse> Verses
    {
        get { return _verses; }
    }

    public Reference Reference1 { get; }
    public string V { get; }

    public Scripture(string reference, List<Verse> verses)
    {
        _reference = reference;
        _verses = verses;
    }

    public Scripture(Reference reference, string v)
    {
        Reference1 = reference;
        V = v;
    }

    public override string ToString()
    {
        string result = "";
        foreach (Verse verse in _verses)
        {
            result += verse.ToString() + " ";
        }
        return result.Trim();
    }
    
}
