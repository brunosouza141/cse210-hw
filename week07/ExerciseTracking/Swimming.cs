using System;


class Swimming : Activity
{
    private int _swimmingLaps;
    public Swimming(double distance, double minutes, int swimmingLaps) : base(distance, minutes)
    {
        _swimmingLaps = swimmingLaps;
    }
    public override double Distance(double distance)
    {
        return _swimmingLaps * 50 / 1000;
    }
    public override double Speed(double distance, double minutes)
    {
        return (Distance(_distance) / minutes) * 60;
    }
    public override double Pace(double minutes, double distance)
    {
        return 60 / Speed(Distance(_distance), _minutes);
    }
    public override string GetSummary()
    {
        return $"{_dateTime.Day} {_dateTime.ToString("MMM")} {_dateTime.Year} Swimming ({_minutes} min): Distance {Distance(_distance):F2} km, Speed: {Speed(Distance(_distance),_minutes):F2} kph, Pace: {Pace(_minutes,Distance(_distance)):F2} min per km";
    }
}