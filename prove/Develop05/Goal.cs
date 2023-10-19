using System;
using System.IO; 

public abstract class Goal
{
    // Member variables
    protected string _shortName;
    protected string _description;
    protected int _points;
    

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Methods
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string detail = $"[ ] {_shortName} ({_description})";
        
        if (IsComplete() == true)   
        {
            detail = $"[x] {_shortName} ({_description})";
        }

        return detail;
    }

    public abstract string GetStringRepresentation();
    
}