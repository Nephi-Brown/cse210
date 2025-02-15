using System;
using System.Collections.Generic;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int breathingDuration = ActivityDuration();
        int interval = 5;
        DateTime endTime = DateTime.Now.AddSeconds(breathingDuration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            Countdown(interval);
            Console.WriteLine();
            Console.Write("Breathe out...");
            Countdown(interval);
            Console.WriteLine();
        }
    }
}
