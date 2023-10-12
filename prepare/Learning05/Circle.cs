using System;

public class Circle : Shape
{
    // Member variables
    private double _radius;
    
    // Constructor 
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Call the abstract methos from the base class and override it
    public override double GetArea()
    {
        // return 3.14 * (_radius * _radius);
        return _radius * _radius * Math.PI; //use the Math.PI class system
    }
}