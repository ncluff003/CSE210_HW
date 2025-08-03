using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _count;

    public ListingActivity(string activity, string description)
        : base(activity, description) { }

    public void AddPrompt(string prompt)
    {
        this._prompts.Add(prompt);
    }

    public void Run()
    {
        this.DisplayIntroduction();
        Console.Clear();

        Console.WriteLine("Get Ready...");

        this.ShowSpinner();
    }
}
