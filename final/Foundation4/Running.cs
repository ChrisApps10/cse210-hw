using System;

class Running : Activity
{
    
    public Running(string date, string type, int duration, int distance) : base(date, type, duration)
    {
        _date = date;
        _type = type;
        _duration = duration;
        _distance = distance;
    }
    public override string GetSummary()
    {
        _pace = _duration / _distance;
        _speed = 60 / _pace;
        string summary = ($"{_date} {_type} ({_duration} minutes) - Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile");
        return summary;
    }
}