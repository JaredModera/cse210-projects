using System;

public class Event
{
    // Member variables
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    // Getters and Setters
    // public Address GetAddress()
    // {
    //     return _address;
    // }
    // Construtors
    public Event(Address address)
    {
        _eventType = "";
        _eventTitle = "";
        _description = "";
        _date = "";
        _time = "";
        _address = address;
    }
    
    // Methods
    public void StandarDetails()
    {
        Console.WriteLine($"Title: {_eventTitle} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address.AddressString()}\n");
    }
    
    public void ShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType} \nTitle: {_eventTitle} \nDate: {_date} \n");
    }

}