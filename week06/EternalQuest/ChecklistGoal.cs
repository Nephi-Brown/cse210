using System;
using System.Collections.Generic;
using System.IO;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                _isComplete = true;
            }
        }
        else
        {
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        if (_isComplete == true)
        {
            return "[X]"; 
        }
        else
        {
            return "[ ]"; 
        }
    }

    public int BonusPoints => _bonusPoints;
    public int CurrentCount => _currentCount;
    public int TargetCount => _targetCount;
}
