using System;

class Points
{
    private int _pointsRecord = 0;

    public Points()
    {
    }

    public int getPoints()
    {
        return _pointsRecord;
    }

    public void setPoints(int points)
    {
        _pointsRecord = _pointsRecord + points;
    }
}