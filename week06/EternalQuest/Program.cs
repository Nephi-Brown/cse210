//Added a username piece to make the program more personel 
//Added a levelling system that changes the title associated with your username depending on how many points you have. Title changes every 1000 points.

using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager = new GoalManager();
        Console.WriteLine("Please enter your username!");
        string userName = Console.ReadLine();
        string userFile = userName + "txt";
        Console.WriteLine("\nWould you like to load your account? y/n");
        string loadingChoice = Console.ReadLine();
        if (loadingChoice == "y")
        {
            goalManager.LoadGoals(userFile);
        }
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();
        while (true)
        {
            
            Console.Clear();
            goalManager.DisplayScore(userName);
            Console.WriteLine("Eternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.AddGoal(); 
                    Console.WriteLine("Goal added successfully!");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case "3":
                    goalManager.SaveGoals(userFile);
                    Console.WriteLine("Goals saved successfully!");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case "4":
                    goalManager.LoadGoals(userFile);
                    Console.WriteLine("Goals loaded successfully!");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Write("Enter the name of the goal to record an event: ");
                    string eventGoalName = Console.ReadLine();
                    goalManager.RecordEvent(eventGoalName);
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case "6":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}