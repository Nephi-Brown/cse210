using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2025, 7, 09), 30, 4.8),
            new Cycling(new DateTime(2024, 11, 14), 45, 15.0),   
            new Swimming(new DateTime(2023, 1, 20), 22, 35),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}