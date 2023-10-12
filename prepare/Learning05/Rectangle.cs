using System;

public class Rectangle : Shape
{
    // Member variables
    private double _length;
    private double _width;
    
    // Constructor 
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Call the abstract methos from the base class and override it
    public override double GetArea()
    {
        return _width * _length;
    }
}