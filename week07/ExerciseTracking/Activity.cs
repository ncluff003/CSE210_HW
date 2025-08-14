using System;

public class Activity
{
    private DateTime date;
    private int _duration; // in minutes.
    private string _activityType;

    public Activity(DateTime date, string activity, int duration)
    {
        this.date = date;
        if (duration < 0)
        {
            throw new ArgumentOutOfRangeException("Duration cannot be negative.");
        }
        this._activityType = activity;
        this._duration = duration;
    }

    public string GetActivityType()
    {
        return this._activityType;
    }

    public int GetDuration()
    {
        return this._duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public DateTime GetDate()
    {
        return this.date;
    }

    public virtual string GetSummary()
    {
        return $"{this.GetDate().ToShortDateString()} {this.GetActivityType()} ({this.GetDuration()} min) - Distance: {this.GetDistance()} km, Speed: {this.GetSpeed()} km/h, Pace: {this.GetPace()} min/km";
    }
}
