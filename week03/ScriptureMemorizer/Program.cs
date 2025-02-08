//Added a Library of Scriptures to select from, rather than using the same scripture each time the program is called.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<Scripture> _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Ruth", 4, 7), "Now this was the manner in former time in Israel concerning redeeming and concerning changing, for to confirm all things; a man plucked off his shoe, and gave it to his neighbour: and this was a testimony in Israel."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),
            new Scripture(new Reference("Genesis", 1, 1), "In the beginning God created the heaven and the earth."),
            new Scripture(new Reference("Luke", 16, 8), "And the lord commended the unjust steward, because he had done wisely: for the children of this world are in their generation wiser than the children of light."),
            new Scripture(new Reference("Psalms", 23, 1), "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Isaiah", 40, 31), "But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint."),
            new Scripture(new Reference("1 Nephi", 3, 7, 8), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. And it came to pass that I, Nephi, was exceedingly young, yet large in stature; and the words which I spake were plain and powerful."),
            new Scripture(new Reference("Mosiah", 2, 17, 18), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God. When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("1 Nephi", 1, 20, 21), "But behold, I, Nephi, will show unto you that the tender mercies of the Lord are over all those whom he hath chosen, because of their faith, to make them mighty even unto the power of deliverance. And I, Nephi, have written these things unto my people, that perhaps I might persuade them that they would remember the Lord their Redeemer."),
            new Scripture(new Reference("D&C", 81, 1), "Verily, verily, I say unto you my servant Frederick G. Williams: Listen to the voice of him who speaketh, to the word of the Lord your God, and hearken to the calling wherewith you are called, even to be a high priest in my church, and a counselor unto my servant Joseph Smith, Jun.;"),      
        };

        Random random = new Random();
        Scripture selectedScripture = _scriptures[random.Next(_scriptures.Count)]; // Randomly selects a scripture

        while (true)
        {
            Console.Clear();
            selectedScripture.Display();
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            if (selectedScripture.AllWordsHidden())
                break;
            selectedScripture.HideRandomWords(3);
        }
    }
}

