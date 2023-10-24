using System;

public abstract class Activity
{
    // Member variables
    protected string _name;
    protected string _date;
    protected double _time;
    protected double _speed;
    protected double _distance;
    protected double _pace;

    // Constructors
    public Activity()
    {
        _name = ""; 
        _date = "";
        _time = 0;
        _speed = 0;
        _distance = 0;
        _pace = 0;
    }

    // Methods
    public abstract void GetSummary();

    public virtual double GetSpeed()
    {
        _speed = (_distance / _time) * 60;
        return _speed;
    }
    public virtual double GetDistance()
    {
        _distance = _speed * (_time / 60);
        return _distance;
    }
    public virtual double GetPace()
    {
        _pace = _time / _distance;
        
        return _pace;
    }
}