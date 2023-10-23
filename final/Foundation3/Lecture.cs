using System;

public class Lecture : Event
{
    // Member variables
    private string _speaker;
    private string _capacity;

    // Construtors
    public Lecture(Address address) : base(address)
    {
        _eventType = "Lecture Event";
        _eventTitle = "Stephen King Greatest Tips";
        _description = "Join us in this conference given by Stephen King about his secrets in how to write any history you imagine!";
        _date = "April 19";
        _time = "9:00 PM";
        _speaker = "Stephen King";
        _capacity = "50";

    }
    // Methods
    public void FullDetails()
    {
        Console.WriteLine($"Event Type:{_eventType} \nTitle: {_eventTitle} \nSpeaker: {_speaker} \nDescription: {_description} \nCapacity: {_capacity} \nDate: {_date} \nTime: {_time} \nAddress: {_address.AddressString()} \n");
    }
}