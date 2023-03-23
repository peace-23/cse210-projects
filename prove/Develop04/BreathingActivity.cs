using System;
using System.Collections.Generic;
using System.Threading;



public class BreathingActivity : Activities
// public class BreathingActivity
{
    private int _duration;

    public BreathingActivity(int duration)
    {
        _duration = duration;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Breathing Activity");

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        PauseWithAnimation(5);

        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(2);

            Console.WriteLine("Breathe out...");
            PauseWithAnimation(2);
        }

        Console.WriteLine("Good job! You have completed the Breathing Activity.");
        Console.WriteLine("Duration: {0} seconds", _duration);
        PauseWithAnimation(3);
    }

    private void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
