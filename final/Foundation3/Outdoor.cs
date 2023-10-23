using System;

public class Outdoor : Event
{
    // Member variables
    private string _weather;

    // Construtors
     public Outdoor(Address address) : base(address)
    {
        _eventType = "Outdoor Event";
        _eventTitle = "The Beatles Concert";
        _description = "Live performance by the band -The Beatles- for the people with good taste in music ";
        _date = "June 18";
        _time = "12:00 PM";
        _weather = "Sunny";
    }
    // Methods
    public void FullDetails()
    {
        Console.WriteLine($"Event Type:{_eventType} \nTitle: {_eventTitle} \nDescription: {_description} \nWeather: {_weather} \nDate: {_date} \nTime: {_time} \nAddress: {_address.AddressString()} \n");
    }
}