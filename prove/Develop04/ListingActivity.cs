using System;
using System.Collections.Generic;
using System.Threading;

// public class ListingActivity
public class ListingActivity : Activities
{
    private int duration;

    public ListingActivity(int duration)
    {
        this.duration = duration;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Listing Activity");

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

    private static void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
