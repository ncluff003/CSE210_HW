using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        return;
    }

    public override string WriteDetails()
    {
        return $"Eternal Goal:{this.RetrieveGoal()}|{this.RetrieveDescription()}|{this.RetrievePoints()}";
    }

    public override Boolean IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{this.RetrieveGoal()} ({this.RetrieveDescription()})";
    }

    public override string GetStringRepresentation()
    {
        string completedIndicator = "[ ]";

        return $"{completedIndicator} {this.GetDetailsString()}";
    }
}
