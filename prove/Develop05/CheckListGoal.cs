using System;
using System.Globalization;
using System.IO; 
using System.Net.NetworkInformation;

public class CheckListGoal : Goal
{
    // Member variables
    private int _amountComplete;
    private int _target;
    private int _bonus;

    // Constructor
    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountComplete = 0;
        _target = target;
        _bonus = bonus;
    }

    // Methods
    public override int RecordEvent()
    { 

        if (_amountComplete < _target)
        {
            _amountComplete++;

            if (_amountComplete < _target)
            {
                return _points;
            }
            else if (_amountComplete == _target)
            {
                _points += _bonus;

            }
        }

        else if (_amountComplete == _target)
        {
            _points = 0;
        }
        
        return _points;
    }
    
    public override bool IsComplete() 
    {
        return _amountComplete == _target;
    }

    public int AmountComplete(int amount)
    {
        _amountComplete = amount;
        return amount;
    }

    public override string GetDetailsString()
    {
        string detail = $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountComplete}/{_target}";

        if (IsComplete() == true)   
        {
            detail = $"[x] {_shortName} ({_description}) -- Currently completed: {_amountComplete}/{_target}";
        }

        return detail;
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName}:{_description}:{_points}:{_bonus}:{_target}:{_amountComplete}";
    }
}