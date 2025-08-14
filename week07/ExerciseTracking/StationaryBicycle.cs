using System;

public class StationaryBike : Activity
{
    private int _speed;

    public StationaryBike(DateTime date, string activity, int duration, int speed)
        : base(date, activity, duration)
    {
        if (speed < 0)
        {
            throw new ArgumentOutOfRangeException("Speed cannot be negative.");
        }
        this._speed = speed;
    }

    public override double GetSpeed()
    {
        return this._speed;
    }

    public override double GetDistance()
    {
        if (this.GetDuration() == 0)
        {
            return 0; // Avoid division by zero
        }
        return (double)(this.GetSpeed() * this.GetDuration() / 60); // Distance in km
    }

    public override double GetPace()
    {
        if (this.GetSpeed() == 0)
        {
            return 0; // Avoid division by zero
        }
        return (double)(60 / this.GetSpeed()); // Pace in min/km
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }
}
