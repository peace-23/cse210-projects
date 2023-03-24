using System;
using System.Collections.Generic;
using System.Threading;


namespace MindfulnessProgram;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Start program");
            Console.WriteLine("2. About");
            Console.WriteLine("3. Exit");

            int choice = ReadIntInRange("Enter your choice: ", 1, 3);

            switch (choice)
            {
                case 1:
                    MindfulnessProgram.Start();
                    break;
                case 2:
                    About();
                    break;
                case 3:
                    exit = true;
                    break;
            }
        }
    }

    static void About()
    {
        Console.Clear();
        Console.WriteLine("About");
        Console.WriteLine("This program was created to help individuals practice mindfulness and focus on their mental health.");
        Console.WriteLine("Version 1.0");
        Console.WriteLine("Author: Peace Arikpo");
        PauseWithAnimation(5);
    }

    static int ReadIntInRange(string prompt, int min, int max)
    {
        int result;

        while (true)
        {
            Console.Write(prompt);

            if (int.TryParse(Console.ReadLine(), out result) && result >= min && result <= max)
            {
                return result;
            }

            Console.WriteLine($"Invalid input. Enter a number between {min} and {max}.");
        }
    }

    static void PauseWithAnimation(int seconds)
    {
        Console.Write("Starting in ");
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}



// ===================================

// using System;
// using System.Threading;

// namespace ActivityTracker
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Welcome to Activity Tracker!");

//             while (true)
//             {
//                 Console.WriteLine("Select an option:");
//                 Console.WriteLine("1. Log an activity");
//                 Console.WriteLine("2. List all activities");
//                 Console.WriteLine("3. Exit");

//                 string choice = Console.ReadLine();
//                 switch (choice)
//                 {
//                     case "1":
//                         LoggingActivity();
//                         break;
//                     case "2":
//                         ListingActivity();
//                         break;
//                     case "3":
//                         Console.WriteLine("Exiting program. Goodbye!");
//                         return;
//                     default:
//                         Console.WriteLine("Invalid option. Try again.");
//                         break;
//                 }
//             }
//         }

//         static void LoggingActivity()
//         {
//             Console.Clear();
//             Console.WriteLine("Logging Activity");
//             string name = ReadString("Enter name: ");
//             int duration = ReadIntInRange("Enter duration in seconds: ", 1, int.MaxValue);
//             DateTime startTime = DateTime.Now;

//             Console.WriteLine("Press any key to stop activity...");
//             Console.ReadKey();

//             DateTime endTime = DateTime.Now;
//             TimeSpan elapsed = endTime - startTime;
//             double elapsedSeconds = elapsed.TotalSeconds;

//             if (elapsedSeconds < duration)
//             {
//                 Console.WriteLine("Activity did not meet the required duration.");
//             }
//             else
//             {
//                 Console.WriteLine($"Activity logged - {name} for {elapsedSeconds} seconds.");
//             }

//             // Pause for a second before returning to main menu
//             Console.WriteLine("Going to sleep for a second...");
//             Thread.Sleep(1000);
//             Console.WriteLine("I'm back!!");
//         }

//         static void ListingActivity()
//         {
//             Console.Clear();
//             Console.WriteLine("Listing Activity");
//             int duration = ReadIntInRange("Enter duration in seconds: ", 1, int.MaxValue);

//             // Display countdown timer animation
//             Console.Write("Loading ");
//             for (int i = 3; i >= 1; i--)
//             {
//                 Console.Write(i);
//                 Thread.Sleep(1000);
//                 Console.Write("\b \b");
//             }
//             Console.WriteLine("GO!");

//             // Simulate loading activities
//             Console.WriteLine("Loading activities...");
//             Thread.Sleep(3000);

//             // Fake activity list
//             string[] activities = { "Activity 1", "Activity 2", "Activity 3", "Activity 4", "Activity 5" };
//             Console.WriteLine($"Activities longer than {duration} seconds:");
//             foreach (string activity in activities)
//             {
//                 // Simulate checking activity duration
//                 Thread.Sleep(500);

//                 // Check if activity meets duration requirement
//                 if (activity.Length > duration)
//                 {
//                     Console.WriteLine(activity);
//                 }
//             }

//             // Pause for a second before returning to main menu
//             Console.WriteLine("Going to sleep for a second...");
//             Thread.Sleep(1000);
//             Console.WriteLine("I'm back!!");
//         }

//         static string ReadString(string message)
//         {
//             Console.Write(message);
//             return Console.ReadLine();
//         }

//         static int ReadIntInRange(string message, int min, int max)
//         {
//             int result;
//             while (true)
//             {
//                 Console.Write(message);
//                 if (int.TryParse(Console.ReadLine(), out result) && result >= min && result <= max)
//                 {
//                     return result;
//                 }
//                 Console.WriteLine($"Invalid input. Please enter an integer between {min} and {max}.");
//             }
//         }
//     }
// }
