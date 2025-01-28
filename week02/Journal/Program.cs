//Added code to prevent nothing being displayed when certain things are done at certain times, such as asking to display when no entires have been written or loaded.
//Added code to reqest for tags to be put in by the user, treating these tags as a fourth part of the journal entry alongside the existing three(date, prompt and entry)
//Added code to allow the user to display specifically entries on the same date, or entries with the same tag, alongside being able to display all entries.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        //Create counter for tracking entries and start with it set to 0.
        int entriesCounter = 0;
        //Created an append variable that checks if you have loaded from a file or not
        int append = 0;
        string choice;
        do
        {
            Console.WriteLine("Please select one of the following Choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    journal.WriteEntry();
                    entriesCounter = entriesCounter + 1;
                    break;
                case "2":
                    //Added code that prevents displaying if there are no entries to display, and prints an associated message
                    if(entriesCounter == 0)
                    {
                        Console.WriteLine("You do not have any entries to display. Please write an entry first.");
                        break;
                    }
                    journal.DisplayCore();
                    break;
                case "3":
                    Console.WriteLine("What file do you want to load from?");
                    string loadName = Console.ReadLine();
                    journal.LoadFromFile(loadName);
                    //Set counter to 1 so that issues do not arise.
                    entriesCounter = 1;
                    //Set append to 1
                    append = 1;
                    break;
                case "4":
                    //Added code that prevents saving if there are no entries to save, and prints an associated message
                    if(entriesCounter == 0)
                    {
                        Console.WriteLine("You do not have any entries to save. Please write an entry first.");
                        break;
                    }
                    Console.WriteLine("What file would you like to save into?");
                    string fileName = Console.ReadLine();
                    //Changed to pass both fileName and append
                    journal.SaveToFile(fileName, append);
                    //Added code that changes the message for when you save depending on how many entries you have written.
                    if(entriesCounter == 1)
                    {
                        Console.WriteLine("Your entry has been succesfully saved.");
                    }
                    if(entriesCounter > 1)
                    {
                        Console.WriteLine("Your entries have been succesfully saved.");
                    }
                    break;
                case "5":
                    Console.WriteLine("Exiting the Journal Program.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        } while (choice != "5");
    }
}  
   
