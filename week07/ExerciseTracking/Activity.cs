using System;
using System.Collections.Generic;

abstract class Activity
{
    private DateTime _date;
    private int _duration; 

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int ActivityDuration()
    {
        return _duration;
    }

    public abstract double ActivityDistance(); 
    public abstract double ActivitySpeed();   
    public abstract double ActivityPace();    

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_duration} min): " + $"Distance: {ActivityDistance():F2} km, Speed: {ActivitySpeed():F2} kph, Pace: {ActivityPace():F2} min per km";
    }
}
