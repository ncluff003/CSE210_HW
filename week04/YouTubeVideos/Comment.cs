using System;

public class Comment
{
    private string _author = "";
    private string _text = "";

    public Comment(string text, string author)
    {
        this._author = author;
        this._text = text;
    }

    public Comment(string text)
    {
        this._author = "anonymous";
        this._text = text;
    }

    public void DisplayText()
    {
        Console.WriteLine($"Author: {this._author}");
        Console.WriteLine($"Comment: {this._text}");
        Console.WriteLine();
    }
}
