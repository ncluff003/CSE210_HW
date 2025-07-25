using System;

public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {this._title} | Length (e.g. seconds): {this._length}");
        Console.WriteLine($"Author: {this._author}");
        Console.WriteLine($"Comments: ({this._comments.Count})");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine();
        if (this._comments.Count > 0)
        {
            foreach (Comment comment in this._comments)
            {
                comment.DisplayText();
            }
        }
    }

    private void AddComment(Comment comment)
    {
        this._comments.Add(comment);
    }

    public void MakeComment(string text, string author)
    {
        if (author == null || author == "")
        {
            Comment newComment = new Comment(text);
            AddComment(newComment);
        }
        else if (author != null && author != "")
        {
            Comment newComment = new Comment(text, author);
            AddComment(newComment);
        }
    }
}
