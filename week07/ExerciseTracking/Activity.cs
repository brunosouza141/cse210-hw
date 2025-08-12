using System;


abstract class Activity
{
    protected double _distance;
    protected double _minutes;
    protected DateTime _dateTime = DateTime.Now;


    public Activity(double distance, double minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }
    public abstract double Distance(double distance);
    public abstract double Speed(double distance, double minutes);
    public abstract double Pace(double minutes, double distance);
    public virtual string GetSummary()
    {
        return "";
    }

}