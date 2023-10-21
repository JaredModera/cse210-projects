using System;

public class Costumer
{
    // Private Member Variables
    private string _name;
    private Address _address;

    // Getters
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }


    // Constructors
    public Costumer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Methods
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}