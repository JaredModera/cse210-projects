using System;

public class Bicycle : Activity
{
    public Bicycle()
    {
        _name = "Bicycle";
        _date = "05 March 2025";
        _time = 60;
        _speed = 32;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_time} min): Distance {GetDistance()} km, Speed: {_speed} kph, Pace: {GetPace()} min per km \n");
    }
}