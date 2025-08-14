using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        this._target = target;
        this._bonus = bonus;
    }

    public void SetAmountCompleted(int amount)
    {
        if (amount < 0 || amount > this._target)
        {
            throw new ArgumentOutOfRangeException(
                "Amount completed cannot be negative or exceed target."
            );
        }
        this._amountCompleted = amount;
    }

    public int RetrieveAmountCompleted()
    {
        return this._amountCompleted;
    }

    public int RetrieveTarget()
    {
        return this._target;
    }

    private void IncrementAmountCompleted()
    {
        if (this._amountCompleted < this._target)
        {
            this._amountCompleted++;
        }
    }

    public override void RecordEvent()
    {
        this.IncrementAmountCompleted();
    }

    public override string WriteDetails()
    {
        return $"Checklist Goal:{this.RetrieveGoal()}|{this.RetrieveDescription()}|{this.RetrievePoints()}|{this._bonus}|{this.RetrieveAmountCompleted()}|{this.RetrieveTarget()}";
    }

    public override Boolean IsComplete()
    {
        return this._amountCompleted == this._target;
    }

    public override string GetDetailsString()
    {
        return $"{this.RetrieveGoal()} ({this.RetrieveDescription()}) -- Currently completed: {this.RetrieveAmountCompleted()} / {this.RetrieveTarget()}";
    }

    public override string GetStringRepresentation()
    {
        // If the goal is completed, have square brackets with an 'X' inside, if not, do not have that 'X'.
        string completedIndicator = this.IsComplete() ? "[X]" : "[ ]";

        return $"{completedIndicator} {this.GetDetailsString()}";
    }
}
