// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace ScriptureMemorizer
// {
//     public class UserInterface
//         {
//             private Library _library = new Library();
//             private TransformScripture _transformer = new TransformScripture();
//             private DataStore _store = new DataStore();
//             private bool _isRunning = true;

//             public void Run()
//             {
//                 while (_isRunning)
//                 {
//                     Console.Clear();
//                     Console.WriteLine("Enter a scripture reference or 'quit' to exit:");
//                     string input = Console.ReadLine();

//                     if (input.ToLower() == "quit")
//                     {
//                         _isRunning = false;
//                         continue;
//                     }

//                     Scripture scripture = _library.GetScripture(input);

//                     if (scripture == null)
//                     {
//                         Console.WriteLine("Scripture not found.");
//                         Console.WriteLine("Press enter to continue...");
//                         Console.ReadLine();
//                         continue;
//                     }

//                     _store.SaveScripture(scripture);

//                     Console.Clear();
//                     Console.WriteLine("Scripture: ");
//                     Console.WriteLine(scripture.GetReference());
//                     Console.WriteLine(_transformer.Transform(scripture.GetText(), 0));
//                     Console.WriteLine("Press enter to continue or type 'quit' to exit...");

//                     if (Console.ReadLine().ToLower() == "quit")
//                     {
//                         _isRunning = false;
//                         continue;
//                     }

//                     int wordCount = scripture.GetText().Split().Length;
//                     int hiddenCount = 0;

//                     while (hiddenCount < wordCount)
//                     {
//                         Console.Clear();
//                         Console.WriteLine("Scripture: ");
//                         Console.WriteLine(scripture.GetReference());
//                         Console.WriteLine(_transformer.Transform(scripture.GetText(), hiddenCount));
//                         Console.WriteLine("Press enter to continue...");

//                         Console.ReadLine();

//                         hiddenCount += 1;
//                     }
//                 }
//             }
//         }
// }