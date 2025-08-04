using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string activity, string description)
        : base(activity, description) { }

    public void AddPrompt(string prompt)
    {
        this._prompts.Add(prompt);
    }

    public void AddQuestion(string question)
    {
        this._questions.Add(question);
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(this._prompts.Count);

        Console.WriteLine($" --- {this._prompts[index]} --- ");
    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(this._questions.Count);

        Console.Write($"\n> {this._questions[index]} ");
        this.ShowSpinner(5);
        string userInput = Console.ReadLine();
        this.RemoveQuestion(index);

        if (this._questions.Count == 0)
        {
            this.AddQuestion("Why was this experience meaningful to you?");
            this.AddQuestion("What have you learned from this experience?");
            this.AddQuestion("In what way, if possible, could you have improved?");
            this.AddQuestion("What would you do differently, if you could?");
            this.AddQuestion("Have you ever done anything like this before?");
            this.AddQuestion("How did you get started?");
            this.AddQuestion("If completed, how did you feel when it was completed?");
            this.AddQuestion(
                "If you were, what made this time different than other times you were not as successful?"
            );
            this.AddQuestion("What is your favorite thing about this experience?");
            this.AddQuestion(
                "What could you learn from this experience that applies to other situations?"
            );
            this.AddQuestion("What did you learn about yourself through this experience?");
            this.AddQuestion("How can you keep this experience in mind in the future?");
        }
    }

    private void RemoveQuestion(int index)
    {
        this._questions.Remove(this._questions[index]);
    }

    public void Run()
    {
        this.DisplayIntroduction();
        Console.Clear();

        Console.WriteLine("Get Ready...");

        this.ShowSpinner();

        Console.WriteLine($"\nConsider the following prompt: \n");
        // Below is the way each random prompt would be gotten.

        this.GetRandomPrompt();

        Console.WriteLine($"\n\nWhen you have something in mind, press enter to continue.\n");
        string userInput = Console.ReadLine();

        if (userInput != "")
        {
            return;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(
                $"\nNow ponder on each of the following questions as they are related to this experience."
            );

            for (int n = 5; n > 0; n--)
            {
                Console.Write($"You may begin in: {n}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }

            Console.Clear();

            // Below is the way each random question would be gotten.
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(this.RetrieveDuration());

            while (DateTime.Now < endTime)
            {
                for (int i = 10; i > 0; i--)
                {
                    this.GetRandomQuestion();
                }
            }

            this.DisplayCongratulations();
        }
    }
}
