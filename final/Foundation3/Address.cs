using System;

public class Address
{
    // Member Variables
    private string _address;
    
    // Costructors
    public Address(string addres)
    {
        _address = addres;

    }

    // Methods
    public string AddressString()
    {
        return $"{_address} \n";
    }
}