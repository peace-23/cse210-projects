using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class UserInterface
        {
            private Library library = new Library();
            private TransformScripture transformer = new TransformScripture();
            private DataStore store = new DataStore();
            private bool isRunning = true;

            public void Run()
            {
                while (isRunning)
                {
                    Console.Clear();
                    Console.WriteLine("Enter a scripture reference or 'quit' to exit:");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                    {
                        isRunning = false;
                        continue;
                    }

                    Scripture scripture = library.GetScripture(input);

                    if (scripture == null)
                    {
                        Console.WriteLine("Scripture not found.");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        continue;
                    }

                    store.SaveScripture(scripture);

                    Console.Clear();
                    Console.WriteLine("Scripture: ");
                    Console.WriteLine(scripture.GetReference());
                    Console.WriteLine(transformer.Transform(scripture.GetText(), 0));
                    Console.WriteLine("Press enter to continue or type 'quit' to exit...");

                    if (Console.ReadLine().ToLower() == "quit")
                    {
                        isRunning = false;
                        continue;
                    }

                    int wordCount = scripture.GetText().Split().Length;
                    int hiddenCount = 0;

                    while (hiddenCount < wordCount)
                    {
                        Console.Clear();
                        Console.WriteLine("Scripture: ");
                        Console.WriteLine(scripture.GetReference());
                        Console.WriteLine(transformer.Transform(scripture.GetText(), hiddenCount));
                        Console.WriteLine("Press enter to continue...");

                        Console.ReadLine();

                        hiddenCount += 1;
                    }
                }
            }
        }
}