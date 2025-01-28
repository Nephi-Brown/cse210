using System;

public class Prompts
{
   public List<string> _prompts = new List<string>  
    {
        "Who was the most interesting person I interacted with today at work?",
        "What was the most interesting part of your day?",
        "How did I see the Lord in my life today?",
        "Did I help someone today?",
        "Did I do something on my bucket list today?",
        "What did I do on my vacation today?",
        "What was the most challenging obstacle I encountered today?",
        "What new skill did I learn today?",
        "What made me laugh the hardest today?",
        "What made me cry today?",
        "Who did I speak to today that I had not spoken to in a long time?",
        "What was the most peaceful moment in my day?",
        "What did I do today for my personal self-care?",
        "What am I most grateful for today?",
        "If I could do one thing over again today, what would that be?",
        "What was one thing you learned today?",
        "Where would you have liked to go today that you didn't?",
        "When did you feel hsppiest today?",
   };
   public Random random = new Random();

   public string GetRandomPrompt()
   {
      string prompt = _prompts[random.Next(_prompts.Count)];
      return prompt;
   }
}
