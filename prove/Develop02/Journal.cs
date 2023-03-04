using System;
public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("There are no entries in the journal.");
            return;
        }

        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.GetEntryAsCSV());
            }
        }

        Console.WriteLine("Journal saved to " + filename + " successfully!");
    }

    public void LoadFromFile(string filename)
    {
        List<Entry> loadedEntries = new List<Entry>();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry entry = new Entry(parts[0], parts[1], parts[2]);
            loadedEntries.Add(entry);
        }

        entries = loadedEntries;
        Console.WriteLine("Journal loaded from " + filename + " successfully!");
    }
}