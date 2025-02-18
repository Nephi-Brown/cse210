using System;
using System.Collections.Generic;

class Swimming : Activity
{
    private double _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double ActivityDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double ActivitySpeed()
    {
        return (ActivityDistance() / ActivityDuration()) * 60;
    }

    public override double ActivityPace()
    {
        return ActivityDuration() / ActivityDistance();
    }
}
