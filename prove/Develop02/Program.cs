using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var promptGenerator = new PromptGenerator();
        var journalEntries = new List<Entry>();

        // Continuously prompt the user for input until they exit
        while (true)
        {
            Console.WriteLine("Enter 'q' to quit, 'p' to generate a prompt, or 'e' to add an entry manually.");

            var input = Console.ReadLine();

            if (input == "q")
            {
                // Save all entries to file
                SaveEntriesToFile(journalEntries);
                break;
            }
            else if (input == "p")
            {
                // Generate a random prompt and display it to the user
                var prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                // Allow the user to enter their response
                var response = Console.ReadLine();

                // Create a new Entry object with the prompt, response, and current date
                var entry = new Entry(prompt, response, DateTime.Now.ToString());

                // Add the entry to the list of journal entries
                journalEntries.Add(entry);
            }
            else if (input == "e")
            {
                // Prompt the user for the entry details
                Console.Write("Enter a prompt: ");
                var prompt = Console.ReadLine();
                Console.Write("Enter a response: ");
                var response = Console.ReadLine();

                // Create a new Entry object with the prompt, response, and current date
                var entry = new Entry(prompt, response, DateTime.Now.ToString());

                // Add the entry to the list of journal entries
                journalEntries.Add(entry);
            }
        }
    }

    static void SaveEntriesToFile(List<Entry> entries)
    {
        var filePath = "journal_entries.csv";

        using (var writer = new StreamWriter(filePath))
        {
            // Write a header row to the file
            writer.WriteLine("Prompt,Response,Date");

            // Write each entry to the file
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.GetEntryAsCSV());
            }
        }
    }
}