using System;

public class Address
{
    // Private Member Variables
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Getters and Setters
    public string GetCountry()
    {
        return _country;
    }

    // Costructors
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Methods
    public string FullAddress()
    {
        return $"Address: {_streetAddress} {_city} {_state} {_country}\n";
    }
    public bool IsInUSA()
    {
        if (_country == "USA") 
        {
            return true;
        }

        return false;
    }

}