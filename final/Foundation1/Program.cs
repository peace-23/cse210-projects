using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create 3-4 videos and add them to the list
        Video v1 = new Video("Funny Cats", "John Smith", 120);
        v1.AddComment("Alice", "Lol, this made my day!");
        v1.AddComment("Bob", "I can't stop watching this.");
        v1.AddComment("Charlie", "Haha, these cats are hilarious!");
        videos.Add(v1);

        Video v2 = new Video("Amazing Tricks", "Sarah Johnson", 180);
        v2.AddComment("David", "Wow, I never knew you could do that!");
        v2.AddComment("Emily", "This is so cool!");
        videos.Add(v2);

        Video v3 = new Video("Travel Vlog", "Mike Brown", 240);
        v3.AddComment("Fiona", "I love seeing all these different places!");
        v3.AddComment("George", "I wish I could travel like this.");
        v3.AddComment("Hannah", "The cinematography is amazing!");
        v3.AddComment("Isaac", "This is inspiring me to plan my next trip.");
        videos.Add(v3);

        Video v4 = new Video("Gaming Highlights", "Gamer123", 50);
        v4.AddComment("PixelPusher", "You're so good at this game!");
        v4.AddComment("CosmicDancer", "I'm a big fan!");
        v4.AddComment("StarryNight", "This is amazing!");
        videos.Add(v4);

        // Iterate through the list of videos and display their details and comments
        foreach (Video v in videos)
        {
            Console.WriteLine("Title: " + v.Title);
            Console.WriteLine("Author: " + v.Author);
            Console.WriteLine("Length: " + v.Length + " seconds");
            Console.WriteLine("Number of comments: " + v.GetNumberOfComments());
            Console.WriteLine("********************");

            Console.WriteLine("Comments:");
            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine(c.Author + ": " + c.Text);
            }
            Console.WriteLine("==================================================");
            Console.WriteLine();
            
        }
    }
}