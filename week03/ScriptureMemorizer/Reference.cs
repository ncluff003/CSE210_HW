using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd = 0)
    {
        _book = book;
        _chapter = chapter;
        _verse = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        if (this._verseEnd != 0)
        {
            return $"{this._book} {this._chapter}:{this._verse}-{this._verseEnd}";
        }
        else
        {
            return $"{this._book} {this._chapter}:{this._verse}";
        }
    }
}
