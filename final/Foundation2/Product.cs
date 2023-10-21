using System;

public class Product
{
    // Private Member Variables
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    // Getters and Setters
    public int GetId()
    {
        return _id;
    }
    public string GetName()
    {
        return _name;
    }
    
    // Constructors
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Methods
    public double CalculateProductPrice()
    {
        double price = _price * _quantity;
        return price;
    }
}