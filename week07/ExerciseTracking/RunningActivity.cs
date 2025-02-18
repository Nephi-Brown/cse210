using System;
using System.Collections.Generic;

class Running : Activity
{
    private double _distance; 

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double ActivityDistance()
    {
        return _distance;
    }

    public override double ActivitySpeed()
    {
        return (_distance / ActivityDuration()) * 60;
    }

    public override double ActivityPace()
    {
        return ActivityDuration() / _distance;
    }
}
