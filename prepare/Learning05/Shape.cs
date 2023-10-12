using System;
using System.Drawing;

public abstract class Shape //abstract class because of the abstract method
{
    //Member variables
    private string _color;

    //Constructor
    public Shape(string color)
    {
        _color = color;
    }

    //Getter
    public string GetColor() 
    {
        return _color;
    }

    //Setter
    public void SetColor(string color)
    {
        _color = color;
    }

    //Abstract method
    public abstract double GetArea();//dont have a body
}
