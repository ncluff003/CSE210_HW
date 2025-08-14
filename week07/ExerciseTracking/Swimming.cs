using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, string activity, int duration, int laps)
        : base(date, activity, duration)
    {
        if (laps < 0)
        {
            throw new ArgumentOutOfRangeException("Laps cannot be negative.");
        }
        this._laps = laps;
    }

    public override double GetDistance()
    {
        // Assuming each lap is 50 meters, convert to kilometers
        return (double)(this._laps * 50) / 1000; // Distance in km
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
        return (double)(this.GetDuration() / this._laps); // Pace in min/lap
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }
}
