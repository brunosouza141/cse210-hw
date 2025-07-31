using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;
    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "not set";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}