using System;
using System.Collections.Generic;
using System.Text;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) 
        : base(title, description, date, time, address)
    {
        this._weatherForecast = weatherForecast;
    }

    public override string GetStandardDetails()
    {
        return base.GetStandardDetails();
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType of event: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }


}