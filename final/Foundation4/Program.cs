using System;
using Foundation4;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Nov 2023",30,3.0);
        Cycling cycling = new Cycling("01 May 2023",30,3.9);
        Swimming swimming = new Swimming("14 Dec 2023",30,5);

        List<Activity> activities = new List<Activity>{
            running,
            cycling,
            swimming
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(new string('-',100));
            Console.WriteLine();
            Console.WriteLine(activity.getSummary());
            Console.WriteLine();
        }
    }
}