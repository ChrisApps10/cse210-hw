using System;

class Swimming : Activity
{
    private float _swimmingLaps;
    
    public Swimming(string date, string type, float duration, float laps) : base(date, type, duration)
    {
        _swimmingLaps = laps;
        _date = date;
        _type = type;
        _duration = duration;
    }

    public override string GetSummary()
    {
        _distance = _swimmingLaps * 50 / 1000;
        _pace = _duration / _distance;
        _speed = 60 / _pace;
        string summary = ($"{_date} {_type} ({_duration} minutes) - Distance {_distance} km, Speed {_speed} kph, Pace: {_pace} min per km");
        return summary;

    }
}