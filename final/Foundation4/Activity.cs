using System;

class Activity
{
    protected string _date;
    protected string _type;
    protected float _duration;
    protected float _distance;
    protected float _speed;
    protected float _pace;
    public Activity(string date, string type, float duration)
    {
        _date = date;
        _type = type;
        _duration = duration;
    }

    public virtual string GetSummary()
    {
        string summary = ($"{_date} {_type} ({_duration} minutes) - Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile");
        return summary;
    }
}