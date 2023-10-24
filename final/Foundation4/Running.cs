using System;

public class Running : Activity
{
    // Member variables
    // Getters and Setters
    // constructors
    public Running()
    {
        _date = "09 Dic 2024";
        _name = "Running";
        _time = 30.00;
        _distance = 6;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_time} min): Distance {_distance} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km \n");
    }
}