using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;
        }
    }
    public override bool IsCompleted()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        return _amountCompleted.ToString();
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}
