using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, string activity, int duration, double distance)
        : base(date, activity, duration)
    {
        if (distance < 0)
        {
            throw new ArgumentOutOfRangeException("Distance cannot be negative.");
        }
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return (double)this._distance;
    }

    public override double GetSpeed()
    {
        if (this.GetDuration() == 0)
        {
            return 0; // Avoid division by zero
        }
        return (double)(this.GetDistance() / this.GetDuration() * 60); // Speed in km/h
    }

    public override double GetPace()
    {
        if (this.GetDistance() == 0)
        {
            return 0; // Avoid division by zero
        }
        return (double)(this.GetDuration() / this._distance); // Pace in min/km
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }
}
