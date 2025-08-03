using System;

public class Activity
{
    private string _activity;
    private string _description;
    private int _duration;

    public Activity(string activity, string description)
    {
        this._activity = activity;
        this._description = description;
    }

    private void SetDuration(int duration)
    {
        this._duration = duration;
    }

    private void GetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());

        this.SetDuration(duration);
    }

    public int RetrieveDuration()
    {
        return this._duration;
    }

    public void DisplayIntroduction()
    {
        Console.WriteLine($"Welcome to the {this._activity} Activity!\n");
        Console.WriteLine($"{this._description}\n");
        this.GetDuration();
    }

    public void DisplayCongratulations()
    {
        Console.WriteLine("Well Done!!\n");
        this.ShowSpinner();

        Console.WriteLine(
            $"You have completed {this._duration} seconds of the {this._activity} Activity!\n"
        );
    }

    public void ShowCountdown() { }

    public void ShowSpinner(int seconds = 10)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count())
            {
                i = 0;
            }
        }
    }
}
