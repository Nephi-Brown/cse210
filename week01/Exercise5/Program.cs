using System;

class Program
{
        static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();

        return Name;
    }

    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string StrNumber = (Console.ReadLine());
        int IntNumber = int.Parse(StrNumber);

        return IntNumber;
    }

    static int SqrNumber(int Number)
    {
        int Result = Number * Number;
        return Result;
    }

    static void DisplayResult(string Name, int Number)
    {
        Console.WriteLine($"{Name}, the square of your number is {Number}");
    }
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string UName = UserName();
        int UserN = UserNumber();
        int SqrN = SqrNumber(UserN);

        DisplayResult(UName, SqrN);
    }
}