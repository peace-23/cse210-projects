using System;
using System.Collections.Generic;
using System.Text;


public class Program
{
    static void Main(string[] args)
    {
        // Create some events
        Address address1 = new Address("123 Main St", "New York", "NY", "10001");
        Lecture lecture = new Lecture("Introduction to C#", "Learn the basics of C#", new DateTime(2023, 4, 10), new TimeSpan(14, 0, 0), "John Smith", 50, address1);

        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "90001");
        Reception reception = new Reception("Spring Mixer", "Join us for drinks and hors d'oeuvres", new DateTime(2023, 4, 15), new TimeSpan(18, 30, 0), address2, "rsvp@example.com");

        Address address3 = new Address("789 Oak St", "Chicago", "IL", "60601");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy the outdoors with friends and family", new DateTime(2023, 4, 20), new TimeSpan(11, 0, 0), address3, "Sunny and warm");

        List<Event> events = new List<Event>{
            reception,
            outdoorGathering,
            lecture
        };
        


        // Generate marketing messages
        Console.WriteLine("Standard details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("*************************************");

        Console.WriteLine("\nFull details:");
        Console.WriteLine("");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("_______");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("_______");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("***********************************");

        Console.WriteLine("\nShort descriptions:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(outdoorGathering.GetShortDescription());

        Console.ReadLine();
    }
}
