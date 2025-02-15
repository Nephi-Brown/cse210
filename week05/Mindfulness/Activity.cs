using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public void Start()
    {
        RecordActivities makeRecord = new RecordActivities();
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.\n");
        Console.WriteLine(_activityDescription);
        Console.Write("\nEnter the duration of the activity in seconds: ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        IdleAnimation(3);
        Console.Clear();
        PerformActivity();
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_activityName} for {_activityDuration} seconds.");
        IdleAnimation(3);
        makeRecord.LogSession(_activityName, _activityDuration);
    }

    protected abstract void PerformActivity();

    protected void IdleAnimation (int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected int ActivityDuration()
    {
        return _activityDuration;
    }
}
