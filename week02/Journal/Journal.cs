using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Prompts pgen = new Prompts();

    public void WriteEntry()
    {
        Entry entry = new Entry();
        entry._promptText = pgen.GetRandomPrompt();
        Console.WriteLine($"Today's prompt: {entry._promptText}");
        Console.Write("Your response: ");
        entry._entryText = Console.ReadLine();
        entry._date = DateTime.Now.ToShortDateString();
        ///Add code to ask the user to tag their entries with memorable keywords
        Console.WriteLine("Please add tags to your entry. These tags should be important words connected to the entry, like how you are feeling(Happy, Sad, etc.) or what it is about(Family, Work, School, etc. Please seperate tags with a ,)");
        entry._tags = Console.ReadLine();
        _entries.Add(entry);
        Console.WriteLine("Congratulations! Your entry has been added to your journal!");
    }

    //Added DisplayCore function so that user can decide between displaying all or displaying specific entries.
    public void DisplayCore()
    {
        int selection;
        Console.WriteLine("Would you like to view all entries or only entries fufilling a requirments? Please input 1 for all and 2 for specific.");
        selection = Int32.Parse(Console.ReadLine());
        if(selection == 1)
        {
            DisplayAll();
        }
        else
        {
            DisplaySpecific();
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    //Added display specific function to look display a specific tag or date depending on the users decisions.
    public void DisplaySpecific()
    {
        int decision;
        string checkedValue;
        string search;
        Console.WriteLine("Would you like to search through tags, or dates? Please answer 1 or 2");
        decision = Int32.Parse(Console.ReadLine());
        if(decision == 1)
        {
            Console.WriteLine("What tag are you wanting to look at?");
            search = Console.ReadLine();
            foreach (Entry entry in _entries)
            {
                checkedValue = entry._tags;
                bool ignoreCaseSearchResult = checkedValue.Contains(search, System.StringComparison.CurrentCultureIgnoreCase);
                if(ignoreCaseSearchResult == true)
                {
                    entry.Display();
                    Console.WriteLine();
                }
            }
        }
        if(decision == 2)
        {
            Console.WriteLine("What date are you wanting to look at? Please enter in the form M/DD/YYYY");
            search = Console.ReadLine();
            foreach (Entry entry in _entries)
            {
                checkedValue = entry._date;
                bool ignoreCaseSearchResult = checkedValue.Contains(search, System.StringComparison.CurrentCultureIgnoreCase);
                if(ignoreCaseSearchResult == true)
                {
                    entry.Display();
                    Console.WriteLine();
                }
            }
        }
    }


//Changed the funtion to accept both a string and an int.
    public void SaveToFile(string fileName, int append)
    {
        try
        {
            //Added an if  that checks if append is 1 or not. If 1, overwrites file when you write to it. If 0, appends to file when you write to in.
            if(append == 0)
            {
                using (StreamWriter outputFile = File.AppendText(fileName))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText} | {entry._tags}");
                    }
                }   
            }
            else
            {
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText} | {entry._tags}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public void LoadFromFile(string loadName)
    {
        try
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(loadName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 4)
                {
                    Entry entry = new Entry()
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2],
                        _tags = parts[3],
                    };
                    _entries.Add(entry);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}