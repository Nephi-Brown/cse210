//Added a RecordActivities class that records the things the user does in the mindfulness program and how long they do them for. 

using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Display Program Log");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            Activity activity = null;
            RecordActivities recordCall = new RecordActivities();

            switch(choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    recordCall.UserHistory();
                    continue;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    Thread.Sleep(1000);
                    continue;
            };

            activity.Start();
        }
    }
}
