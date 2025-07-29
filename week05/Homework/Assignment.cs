using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment()
    {
        this._studentName = "anonymous";
        this._topic = "unknown";
    }

    public Assignment(string name, string topic)
    {
        this._studentName = name;
        this._topic = topic;
    }

    public string GetSummary()
    {
        return $"{this._studentName} | {this._topic}";
    }
}
