using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
            "How is your mother feeling today?",
            "What did you learn on the Church this week?",
            "How did you feel on the last time you had contact with nature?",
            "What is the strongest emotion you felt today?",
            "How are you feeling about the college?"
    };
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int randomNumber = rand.Next(0, 5);
        return _prompts[randomNumber];
    }
}