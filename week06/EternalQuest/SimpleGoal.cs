using System;

class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points, string completed = "false") : base(name, description, points)
    {
        if (completed == "True")
        {
            RecordEvent();
        }
    }

    public string test(Goal test)
    {
        return "";
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsCompleted()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_isComplete}";
    }
}