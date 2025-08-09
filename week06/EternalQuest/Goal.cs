using System;

public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        this._shortName = name;
        this._description = description;
        this._points = points;
    }

    public virtual void RecordEvent() { }

    public virtual Boolean IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}
