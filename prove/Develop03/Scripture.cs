using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public string Reference { get; private set; }
    public string Text { get; private set; }
    private List<int> hiddenIndices;

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        hiddenIndices = new List<int>();
    }

    public Scripture(string reference, string[] verses)
    {
        Reference = reference;
        Text = String.Join(" ", verses);
        hiddenIndices = new List<int>();
    }

    public int NumHiddenWords()
    {
        return hiddenIndices.Count;
    }

    public bool HideRandomWord()
    {
        List<int> availableIndices = Enumerable.Range(0, Text.Length)
            .Where(i => !hiddenIndices.Contains(i) && Char.IsLetter(Text[i]))
            .ToList();
        if (availableIndices.Count == 0)
        {
            return false;
        }
        int randomIndex = availableIndices[new Random().Next(availableIndices.Count)];
        hiddenIndices.Add(randomIndex);
        return true;
    }

    public string GetVisibleText()
    {
        return new String(Text.Select((c, i) => hiddenIndices.Contains(i) ? '_' : c).ToArray());
    }

    public override string ToString()
    {
        return $"{Reference}: {GetVisibleText()}";
    }
}
