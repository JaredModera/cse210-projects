using System;

public class Order
{
    // Private Member variables
    private List<Product> _products = new List<Product>();
    private Costumer _costumer;
    private double _shippingCost;

    // Getters and Setters
    public List<Product> GetProducts()
    {
        return _products;
    }
    public void SetProducts(Product product)
    {
        _products.Add(product);
    }

    // Constructor
    public Order(Costumer costumer)
    {
        _costumer = costumer;
        _shippingCost = CalculateShippingCost();
    }

    // Methods
    public double CalculateOrderCost()
    {
        double shippingCost = CalculateShippingCost();
        double initialCost = 0;

        foreach (Product product in _products)
        {
            initialCost += product.CalculateProductPrice();
        }

        double cost = initialCost + shippingCost;

        return cost;
    }

    public double CalculateShippingCost()
    {
        if (_costumer.LivesInUSA() == true)
        {
            _shippingCost = 5.0;
        } 
        else 
        {
            _shippingCost = 35.0;
        }
        return _shippingCost;
    }
    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetName()} \nID: {product.GetId()}\n");
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"Costumer: {_costumer.GetName()} \n{_costumer.GetAddress().FullAddress()}");
    }
}