using System;
using System.Collections.Generic;
using System.IO;

class LevelSystem
{
    int _listCounter = 0;
    int _heldValue = 0;
    int checkValue = 0;

    private readonly List<string> _rankTiers = new List<string>
    {
        "Novice Explorer 🟢",
        "Apprentice Adventurer 🔵",
        "Skilled Pathfinder ⚔️",
        "Elite Warrior 🛡",
        "Master Tactician 🎯",
        "Grand Champion 🏆",
        "Legendary Hero 🔥",
        "Mythic Guardian 🌟",
        "Immortal Conqueror ⚡",
        "Eternal Deity 👑"
    };

    public void Tier(int _totalPoints)
    {
        checkValue = _totalPoints - _heldValue;
        int legacyCounter = _listCounter;
        if (checkValue >= 1000)
        {
            _listCounter = _listCounter + 1;
            _heldValue = _heldValue + 1000;
            Console.WriteLine("Congratulations, you have ranked up!\n");
            Console.WriteLine($"Rank: {_rankTiers[legacyCounter]} -> {_rankTiers[_listCounter]}!\n");
        }
        else
        {
            Console.WriteLine($"Rank: {_rankTiers[_listCounter]}!\n");
        }
    }

    public void LoadTier(int _totalPoints)
    {
        checkValue = _totalPoints - _heldValue;
        while (checkValue >= 1000)
        {
            _listCounter = _listCounter + 1;
            _heldValue = _heldValue + 1000;
            checkValue = checkValue - 1000;
        }
    }
}