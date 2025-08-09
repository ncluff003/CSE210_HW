using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        this._goals = new List<Goal>();
        this._score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Hello from the goal manager.");
    }

    public string DisplayPlayerInfo()
    {
        return "";
    }

    public void ListGoalNames() { }

    public void ListGoalDetails() { }

    public void CreateGoal() { }

    public void RecordEvent() { }

    public void SaveGoals() { }

    public void LoadGoals() { }
}
