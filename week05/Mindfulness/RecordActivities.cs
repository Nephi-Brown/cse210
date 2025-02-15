using System;
using System.Collections.Generic;
using System.IO;

class RecordActivities
{
    private string _filePath = "mindfullnesslog.txt";

    public void LogSession(string activityType, int duration)
    {
        File.AppendAllText(_filePath, $"{DateTime.Now}: {activityType} for {duration} seconds\n");
    }

    public void UserHistory()
    {
        if (File.Exists(_filePath))
        {
            string[] records = File.ReadAllLines(_filePath);
            Console.WriteLine("Session History:");
            foreach (string entry in records)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine("Please enter 1 when you want to stop viewing your usage of the program. ");
            string end = Console.ReadLine();
            while (end != "1")
            {
                if(end != "1")
                {
                    end = Console.ReadLine();
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }
        else
        {
            Console.WriteLine("No session history found.");
        }
    }
}
