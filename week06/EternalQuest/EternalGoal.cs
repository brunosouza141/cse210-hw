using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsCompleted()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}