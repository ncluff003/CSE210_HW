using System;

public class PromptGenerator
{

  public List<string> _prompts = new List<string>
  {
    "Who was the most interesting person I interacted with today?",
    "What have I learned today",
    "What was the best part of my day?",
    "What was the most challenging aspect of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What would be one way I could improve my day tomorrow?",
    "What was the strongest emotion I felt today?",
    "Who could I serve or help tomorrow, and how?",
    "If I had one thing I could do over today, what would it be?",
    "How do I feel the Savior would feel about my actions today?"
  };
  public string GetRandomPrompt()
  {
    Random random = new Random();

    int index = random.Next(_prompts.Count);
    
    string prompt = _prompts[index];

    return prompt;
  }
}