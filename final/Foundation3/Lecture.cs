using System;
using System.Collections.Generic;
using System.Text;

public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, TimeSpan duration, string speakerName, int capacity, Address address) : base(title, description, dateTime, duration, address)
    {
        this._speakerName = speakerName;
        this._capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker Name: {_speakerName}\nCapacity: {_capacity}";

    }


}