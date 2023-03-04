class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void DisplayJournalEntries()
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

    public void CreateJournalEntry()
    {
        Console.Write("Enter prompt: ");
        string prompt = Console.ReadLine();

        Console.Write("Enter response: ");
        string response = Console.ReadLine();

        string date = DateTime.Today.ToShortDateString();

        Entry entry = new Entry(prompt, response, date);
        entries.Add(entry);

        Console.WriteLine("Entry created successfully!");
    }
}
