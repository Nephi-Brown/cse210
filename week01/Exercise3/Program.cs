using System;

class Program
{
    static void Main(string[] args)
    {
        string Playgame = "yes";
        while (Playgame == "yes")
        {
            Random randomGenerator = new Random();
            int MagicN = randomGenerator.Next(1, 101);
            int guess = 0;
            int Attempt = 0;
            while (guess != MagicN)
            {
                Attempt = Attempt + 1;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (MagicN > guess)
                {
                    Console.WriteLine("Higher\n");
                }
                else if (MagicN < guess)
                {
                    Console.WriteLine("Lower\n");
                }
                else
                {
                    Console.WriteLine("You guessed it!\n");
                }
            }
            string textVersion = Attempt.ToString();
            Console.Write($"It took you {textVersion} attempts to guess the magic number!\n");
            Console.Write("Would you like to play again? Enter yes if so.\n");
            Playgame = Console.ReadLine();
        }                    
    }
}