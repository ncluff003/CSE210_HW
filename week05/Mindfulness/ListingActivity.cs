using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _count = 0;

    public ListingActivity(string activity, string description)
        : base(activity, description) { }

    public void AddPrompt(string prompt)
    {
        this._prompts.Add(prompt);
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(this._prompts.Count);

        Console.WriteLine($" --- {this._prompts[index]} --- ");
    }

    public void IncrementCount()
    {
        this._count += 1;
    }

    public void DisplayCount()
    {
        Console.WriteLine($"\nYou listed {this._count} items!\n");
    }

    public void Run()
    {
        this.DisplayIntroduction();
        Console.Clear();

        Console.WriteLine("Get Ready...");

        this.ShowSpinner();

        Console.WriteLine($"List as many responses as you can to the following prompt:");

        this.GetRandomPrompt();

        for (int n = 5; n > 0; n--)
        {
            Console.Write($"You may begin in: {n}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }

        // Below is the way each random question would be gotten.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this.RetrieveDuration());

        while (DateTime.Now < endTime)
        {
            if (this._count == 0)
            {
                Console.Write("\n> ");
            }
            else
            {
                Console.Write("> ");
            }
            string answer = Console.ReadLine();
            this.IncrementCount();
        }

        this.DisplayCount();

        this.DisplayCongratulations();
    }
}
