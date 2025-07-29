using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title)
        : base(name, topic)
    {
        this._title = title;
    }

    public string GetWritingInformation()
    {
        return $"{this._title} by {this._studentName}";
    }
}
