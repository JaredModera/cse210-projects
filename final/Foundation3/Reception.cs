using System;

public class Reception : Event
{
    // Member variables
    private string _email;
    // Construtors
    public Reception(Address address) : base(address)
    {
        _eventType = "Reception Event";
        _eventTitle = "Marriage of The Rocks";
        _description = "Join us in the union of the couple Rock";
        _date = "December 7";
        _time = "4:30 PM";
        _email = "thegrandreception@yimail.com";
    }
    // Methods
    public void FullDetails()
    {
        Console.WriteLine($"Event Type:{_eventType} \nTitle: {_eventTitle} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address.AddressString()} \nEmail: {_email} \n");
    }
}