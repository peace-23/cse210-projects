using System;


namespace Develop05;
class Program
{
    static void Main()
    {
        EternalQuest eternalQuest = new EternalQuest();
        Console.WriteLine("Welcome to EternalQuest!\n");

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Load goals from a file");
            Console.WriteLine("2. Add a new goal");
            Console.WriteLine("3. View all goals");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter the filename:");
                    string filename = Console.ReadLine();
                    ConfirmFileLoad(filename, eternalQuest);
                    break;

                case "2":
                    AddNewGoal(eternalQuest);
                    break;

                case "3":
                    ViewAllGoals(eternalQuest);
                    break;

                case "4":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void ConfirmFileLoad(string filename, EternalQuest eternalQuest)
    {
        Console.Clear();

        if (File.Exists(filename))
        {
            eternalQuest.LoadGoals(filename);
            Message("File loaded successfully.");
        }
        else
        {
            Message("No such file in directory.");
        }
    }

    static void AddNewGoal(EternalQuest eternalQuest)
    {
        Console.Clear();

        Console.WriteLine("Enter the new goal:");
        string goal = Console.ReadLine();

        eternalQuest.AddGoal(goal);
        Message("Goal added successfully.");
    }

    static void ViewAllGoals(EternalQuest eternalQuest)
    {
        Console.Clear();

        Console.WriteLine("All goals:");

        foreach (string goal in eternalQuest.GetGoals())
        {
            Console.WriteLine("- " + goal);
        }

        Console.ReadLine();
    }

    static void Message(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Console.ReadLine();
    }
}
