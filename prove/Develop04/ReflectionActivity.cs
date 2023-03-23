using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activities
// public class ReflectionActivity
{
    private int _duration;

    public ReflectionActivity(int duration)
    {
        _duration = duration;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Reflection Activity");

        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        PauseWithAnimation(5);

        string[] prompts = { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        PauseWithAnimation(3);

        string[] questions = { "Why was this experience meaningful to you?", 
                                "Have you ever done anything like this before?", 
                                "How did you get started?", 
                                "How did you feel when it was complete?", 
                                "What made this time different than other times when you were not as successful?", 
                                "What is your favorite thing about this experience?", 
                                "What could you learn from this experience that applies to other situations?", 
                                "What did you learn about yourself through this experience?", 
                                "How can you keep this experience in mind in the future?" };
        for (int i = 0; i < _duration; i++)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine(question);
            PauseWithAnimation(5);
        }

        Console.WriteLine("Good job! You have completed the Reflection Activity.");
        Console.WriteLine("Duration: {0} seconds", _duration);
        PauseWithAnimation(3);
    }

    private static void PauseWithAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\r{0} ", new string(' ', Console.WindowWidth - 1));
            Console.Write("\r{0}", i);
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}




