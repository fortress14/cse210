using System;
using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _prompts = new List<string> {
        "How are you feeling today?",
        "If I had one thing I could do over today, what would it be?",
        "Did you give a simple act of service to someone today?",
        "What valuable lesson did you learn this time?",
        "Did you look on positive side than negative?",
        "Are you feeling thankful today?"
    };

    public string GetRandomPrompt()
    {
        return "";
    }
}
    