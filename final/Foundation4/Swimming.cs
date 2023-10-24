using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming()
    {
        _name = "Swimming";
        _date = "28 Oct 2026";
        _time = 20;
        _laps = 15;
        _speed = 15;
    }

    public override double GetDistance()
    {
        _distance = (_laps * 50) / 1000;
        return _distance;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_time} min): Distance {GetDistance()} km, Speed: {_speed} kph, Pace: {GetPace()} min per km \n");
    }
}
