using System;
using System.Collections.Generic;

class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double ActivityDistance()
    {
        return (_speed * ActivityDuration()) / 60;
    }

    public override double ActivitySpeed()
    {
        return _speed;
    }

    public override double ActivityPace()
    {
        return 60 / _speed;
    }
}
