using System;
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        string LetterG;
        string Modifier = "";
        int Pass;
        int Case;
        Console.Write("What percentage grade did you get? ");
        string PercentG = Console.ReadLine();
        int number = int.Parse(PercentG);
        if (number >= 90)
        {
            LetterG = "an A";
            Pass = 1;
            number = number - 90;
            Case = 1;
        }
        else if (number >= 80)
        {
            LetterG = "a B";
            Pass = 1;
            number = number - 80;
            Case = 0;
        }
        else if (number >= 70)
        {
            LetterG = "a C";
            Pass = 1;
            number = number - 70;
            Case = 0;
        }
        else if (number >= 60)
        {
            LetterG = "a D";
            number = number - 60;
            Case = 0;
            Pass = 0;
        }
        else
        {
            LetterG = "an F";
            Case = 2;
            Pass = 0;
        }
        if (Case == 0 || Case == 1)
        {
            if (number < 3)
            {
                Modifier = "-";
            }
            else if (Case == 0)
            {
                if (number >= 7)
                {
                    Modifier = "+";
                }
            }
        }
        Console.Write($"You got {LetterG}{Modifier}\n");
        if (Pass == 1)
        {
            Console.Write("You passed your class, well done!\n");
        }
        else
        {
            Console.Write("You failed your class, better luck next time.\n");
        }
    }
}