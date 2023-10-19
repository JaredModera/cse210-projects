using System;
using System.Net.NetworkInformation;

public class EternalGoal : Goal
{
    // Member variables

    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    // Methods
    public override int RecordEvent()
    {
        return _points;
    }
    
    public override bool IsComplete() 
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName}:{_description}:{_points}";
    }
}