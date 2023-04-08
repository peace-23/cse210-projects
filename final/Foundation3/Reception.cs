using System;
using System.Collections.Generic;
using System.Text;

public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) 
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetStandardDetails()
    {
        return base.GetStandardDetails();
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType of event: Reception\nEmail: {rsvpEmail}";
    }


}