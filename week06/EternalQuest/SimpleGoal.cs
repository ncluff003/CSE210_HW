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
        this.MarkAsComplete();
        return;
    }

    public override string WriteDetails()
    {
        return $"Simple Goal:{this.RetrieveGoal()}|{this.RetrieveDescription()}|{this.RetrievePoints()}|{this._isComplete}";
    }

    public override Boolean IsComplete()
    {
        return this._isComplete;
    }

    public void MarkAsComplete()
    {
        this._isComplete = true;
    }

    public override string GetDetailsString()
    {
        return $"{this.RetrieveGoal()} ({this.RetrieveDescription()})";
    }

    public override string GetStringRepresentation()
    {
        // If the goal is completed, have square brackets with an 'X' inside, if not, do not have that 'X'.
        string completedIndicator = this._isComplete ? "[X]" : "[ ]";

        return $"{completedIndicator} {this.GetDetailsString()}";
    }
}
