using System;


class Running : Activity
{

    public Running(double distance, double minutes) : base(distance, minutes)
    {
        
    }
    public override double Distance(double distance)
    {
        return _distance;
    }
    public override double Speed(double distance, double minutes)
    {
        return (_distance / _minutes) * 60;
    }
    public override double Pace(double minutes, double distance)
    {
        return _minutes / _distance;
    }
    public override string GetSummary()
    {
        return $"{_dateTime.Day} {_dateTime.ToString("MMM")} {_dateTime.Year} Running ({_minutes} min): Distance {Distance(_distance):F2} km, Speed: {Speed(_distance,_minutes):F2} kph, Pace: {Pace(_minutes,_distance):F2} min per km";
    }
}