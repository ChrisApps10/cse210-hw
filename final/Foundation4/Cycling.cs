using System;

class Cycling : Activity
{
    public Cycling(string date, string type, int duration, int speed) : base(date, type, duration)
    {
        _date = date;
        _type = type;
        _duration = duration;
        _speed = speed;
    }
    public override string GetSummary()
    {
        _pace = _duration / _speed;
        _distance = _speed / 60 * _duration;
        string summary = ($"{_date} {_type} ({_duration} minutes) - Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile");
        return summary;
    }
}