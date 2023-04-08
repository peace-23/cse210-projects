using System;
using System.Collections.Generic;
using System.Text;


public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private TimeSpan _duration;
    private Address _address;


    public Event(string title, string description, DateTime dateTime, TimeSpan duration, Address address)
    {
        this._title = title;
        this._description = description;
        this._dateTime = dateTime;
        this._duration = duration;
        this._address = address;
    }

     public string getTitle()
        {
            return _title;
        }
        public string getDescription()
        {
            return _description;
        }

        public DateTime getDate()
        {
            return _dateTime;
        }

     public Address getAddress()
        {
            return _address;
        }

    public virtual string GetStandardDetails()
    {
        return $"{_title}\nDescription: {_description}\nDate: {_dateTime.ToShortDateString()}\nDuration: {_duration}\nAddress: {_address}";
    }

    
    public virtual string GetFullDetails()
    {
        string address = getAddress().getStringAddress();
        string detailsString = $"Event Titile: {getTitle()}\nEvent Date & Time:{getDate()}\nEvent Description:{getDescription()}\n\nLocation:\n{address}";
        return detailsString;
            

    }


    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {_title}, {_dateTime.ToShortDateString()}";
    }
}