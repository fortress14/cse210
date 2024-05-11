using System;
using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _prompts = new List<string> {
        "How are you feeling today?",
        "If I had one thing I could do over today, what would it be?",
        "Did I gave a simple act of service to someone today?",
        "What valuable lesson did I learn this time?",
        "Did I look on positive side than negative?",
        "Am I feeling thankful today?",
        "What is the most exciting part of the day?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
    