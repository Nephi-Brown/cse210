using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things that you are grateful for as you can.",
        "List as many personal strengths as you can think of.",
        "List as many people as you can who have positively influenced your life.",
        "List as many skills as you can, that you have acquired over the years.",
        "List as many people you have met today as you can.",
        "List as many books of scripture as you can.",
        "List as many movies you enjoy as you can"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the positive aspects of your life by listing as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        int duration = ActivityDuration();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        Countdown(3);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items!");
    }
}
