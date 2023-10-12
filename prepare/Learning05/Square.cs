using System;

public class Square : Shape
{
    // Member variables
    private double _side;
    
    // Constructor 
    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // Call the abstract methos from the base class and override it
    public override double GetArea()
    {
        return _side * _side;
    }
}