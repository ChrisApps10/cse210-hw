using System;

class EternalGoal : goalType
{
    public EternalGoal()
    {
        _completed = false;
    }

    public override int calculatePoints()
    {
        return _goalPoints;
    }

    public override void setCompleted(bool completed)
    {
        _completed = false;
    }

}