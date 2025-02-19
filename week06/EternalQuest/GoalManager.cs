using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;
    LevelSystem level = new LevelSystem();

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal() 
    {
        Console.WriteLine("There are three types of goals:");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("What type of goal do you want to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("Give a short description of your goal: ");
        string goalDescription = Console.ReadLine();
        Console.Write("How many points will this goal be worth? ");
        int goalPoints = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (goalType)
        {
            case "1":
                goal = new SimpleGoal(goalName, goalDescription, goalPoints);
                break;
            case "2":
                goal = new EternalGoal(goalName, goalDescription, goalPoints);
                break;
            case "3":
                Console.Write("How many times must this goal be completed? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points does this goal give? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(goalName, goalDescription, goalPoints, targetCount, bonusPoints);
                break;                
        }

        if (goal != null)
        {
            _goals.Add(goal);
        }
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase))
            {
                goal.RecordEvent();
                _totalPoints += goal.Points;

                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete() == true)
                {
                    _totalPoints = _totalPoints + checklistGoal.BonusPoints;
                }
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{goal.GetStatus()} {goal.Name} ({goal.Description}) -- Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times.");
            }
            else
            {
                Console.WriteLine($"{goal.GetStatus()} {goal.Name} ({goal.Description})");
            }
        }
    }

    public void DisplayScore(string userName)
    {
        Console.WriteLine($"Hi {userName}! You have {_totalPoints} points.\n");
        level.Tier(_totalPoints);
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            foreach (var goal in _goals)
            {
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.GetStatus()},{checklistGoal.CurrentCount},{checklistGoal.TargetCount},{checklistGoal.BonusPoints}");
                }
                else
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.GetStatus()}");
                }
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _totalPoints = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case nameof(SimpleGoal):
                            bool isComplete = parts[4] == "[X]";
                            var simpleGoal = new SimpleGoal(name, description, points);
                            if (isComplete) simpleGoal.RecordEvent();
                            _goals.Add(simpleGoal);
                            break;
                        case nameof(EternalGoal):
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case nameof(ChecklistGoal):
                            isComplete = parts[4] == "[X]";
                            int currentCount = int.Parse(parts[5]);
                            int targetCount = int.Parse(parts[6]);
                            int bonusPoints = int.Parse(parts[7]);
                            var checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                            for (int i = 0; i < currentCount; i++)
                            {
                                checklistGoal.RecordEvent();
                            }
                            if (isComplete) checklistGoal.RecordEvent();
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
            level.LoadTier(_totalPoints);
        }
    }
}