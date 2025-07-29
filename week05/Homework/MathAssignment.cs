using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems)
        : base(name, topic)
    {
        this._textbookSection = section;
        this._problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {this._textbookSection} Problems: {this._problems}";
    }
}
