using System;

public class SimpleGoal : Goal
{
    private Boolean _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        this._isComplete = false;
    }

    public override void RecordEvent()
    {
        return;
    }

    public override Boolean IsComplete()
    {
        return false;
    }

    public string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
