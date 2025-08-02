using System;
using Microsoft.VisualBasic;

public class BreathingActivity : Activity
{
    private int _cycles;

    public BreathingActivity(string activity, string description, int cycles)
        : base(activity, description)
    {
        this._cycles = cycles;
    }

    public void Run()
    {
        this.DisplayIntroduction();
        Console.Clear();

        Console.WriteLine("Get Ready...");

        this.ShowSpinner();

        Console.WriteLine();

        DateTime activityStart = DateTime.Now;
        DateTime activityEnd = activityStart.AddSeconds(this.RetrieveDuration());

        while (DateTime.Now < activityEnd)
        {
            for (int n = 5; n > 0; n--)
            {
                Console.Write($"Breathe In: {n}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int n = 5; n > 0; n--)
            {
                Console.Write($"Breathe Out: {n}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        this.DisplayCongratulations();
    }
}
