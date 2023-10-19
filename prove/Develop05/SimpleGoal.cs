using System;
using System.Net.NetworkInformation;

public class SimpleGoal : Goal
{
    // Member variables
    private bool _isComplete;
    // Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // Methods
    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }
    public override bool IsComplete() 
    {
        return _isComplete;
    }

    // public override string GetDetailsString()
    // {
    //     return $"[ ] {_shortName} {_description}";
    // }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}:{_description}:{_points}:{_isComplete}";
    }
}