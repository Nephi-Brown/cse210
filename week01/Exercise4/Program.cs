using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int EnteredN = -1;
        while (EnteredN != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string Value = Console.ReadLine();
            EnteredN = int.Parse(Value);
            if (EnteredN != 0)
            {
                numbers.Add(EnteredN);
            }
        }
        int Total = 0;
        foreach (int number in numbers)
        {
            Total += number;
        }
        Console.WriteLine($"The Total is: {Total}");
        float Average = ((float)Total) / numbers.Count;
        Console.WriteLine($"The average is: {Average}");
        int Largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > Largest)
            {
                Largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {Largest}");
        int SmallestP = numbers[0];
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (number < SmallestP)
                {
                    SmallestP = number;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {SmallestP}");
    }
}