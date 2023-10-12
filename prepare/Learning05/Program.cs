using System;

class Program
{
    static void Main(string[] args)
    {
        Square sqr1 = new Square("blue", 10);
        // Console.WriteLine(sqr.GetColor());
        // Console.WriteLine(sqr.GetArea());

        Rectangle rect1 = new Rectangle("red", 5, 10);
        // Console.WriteLine(rect.GetColor());
        // Console.WriteLine(rect.GetArea());

        Circle circ1 = new Circle("purple", 5);
        // Console.WriteLine(circ.GetColor());
        // Console.WriteLine(circ.GetArea());

        List<Shape> shapesList = new List<Shape>();
        shapesList.Add(sqr1);
        shapesList.Add(rect1);
        shapesList.Add(circ1);

        foreach (Shape shape in shapesList) 
        {
            // Console.WriteLine($"The Color is {shape.GetColor()} and the area is {shape.GetArea()}"); or

            string color = shape.GetColor();
            double area = shape.GetArea();

            
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}