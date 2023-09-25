using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frt1 = new Fraction();
        Console.WriteLine(frt1.GetFractionString());
        Console.WriteLine(frt1.GetDecimalValue());

        Fraction frt2 = new Fraction(5);
        Console.WriteLine(frt2.GetFractionString());
        Console.WriteLine(frt2.GetDecimalValue());

        Fraction frt3 = new Fraction(3, 4);
        Console.WriteLine(frt3.GetFractionString());
        Console.WriteLine(frt3.GetDecimalValue());

        Fraction frt4 = new Fraction(1, 3);
        Console.WriteLine(frt4.GetFractionString());
        Console.WriteLine(frt4.GetDecimalValue());
        
    }
}