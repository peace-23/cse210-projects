using System;
using System.Collections.Generic;
using System.Threading;

class Activities
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Reflection");
            Console.WriteLine("2. Breathing");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            int choice = ReadIntInRange("Enter your choice: ", 1, 4);

            switch (choice)
            {
                case 1:
                    ReflectionActivity();
                    break;
                case 2:
                    BreathingActivity();
                    break;
                case 3:
                    ListingActivity();
                    break;
                case 4:
                    exit = true;
                    break;
            }
        }
    }

    static void ReflectionActivity()
    {
        Console.Clear();
        Console.WriteLine("Reflection Activity");
        int duration = ReadIntInRange("Enter duration in seconds: ", 1, int.MaxValue);

        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        PauseWithAnimation(5);

        string[] prompts = { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        PauseWithAnimation(3);

        string[] questions = { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
        for (int i = 0; i < duration; i++)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine(question);
            PauseWithAnimation(5);
        }

        Console.WriteLine("Good job! You have completed the Reflection Activity.");
        Console.WriteLine("Duration: {0} seconds", duration);
        PauseWithAnimation(3);
    }

    static void BreathingActivity()
    {
        Console.Clear();
        Console.WriteLine("Breathing Activity");
        int duration = ReadIntInRange("Enter duration in seconds: ", 1, int.MaxValue);

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        PauseWithAnimation(5);

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(2);

            Console.WriteLine("Breathe out...");
            PauseWithAnimation(2);
        }

        Console.WriteLine("Good job! You have completed the Breathing Activity.");
        Console.WriteLine("Duration: {0} seconds", duration);
        PauseWithAnimation(3);
    }

    static void ListingActivity()
    {
        Console.Clear();
        Console.WriteLine("Listing Activity");
        int duration = ReadIntInRange("Enter duration in seconds: ", 1, int.MaxValue);

        Console.WriteLine("This activity will help you organize your thoughts by making a list of things you want to accomplish. Take your time and think about what you want to achieve.");
    PauseWithAnimation(5);

    Console.WriteLine("What are the things you want to accomplish?");
    List<string> list = new List<string>();
    while (true)
    {
        string item = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(item))
        {
            break;
        }
        list.Add(item);
    }

    Console.WriteLine("Here's your list:");
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine("{0}. {1}", i + 1, list[i]);
    }
    PauseWithAnimation(5);

    Console.WriteLine("Good job! You have completed the Listing Activity.");
    Console.WriteLine("Duration: {0} seconds", duration);
    PauseWithAnimation(3);
    }

    static void PauseWithAnimation(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write("Pausing for {0} seconds... ", i);
            Thread.Sleep(1000);
            Console.WriteLine();
        }
    }

    

    static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool validInput;

        do
        {
            Console.Write(prompt);
            validInput = int.TryParse(Console.ReadLine(), out value);

            if (validInput && (value < min || value > max))
            {
                validInput = false;
            }

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter an integer between {0} and {1}.", min, max);
            }
        } while (!validInput);

        return value;
    }

}