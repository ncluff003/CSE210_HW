using System;

public class Word
{
  private string _text;
  private bool _isHidden = false;

  public Word(string text)
  {
    _text = text;
  }

  public void Hide()
  {
    string newWord = "";
    for (int i = 0; i < this._text.Count(); i++)
    {
      newWord += "_";
    }
    this._text = newWord;
    this._isHidden = true;
  }

  public void Show() { }

  public bool IsHidden()
  {
    return _isHidden;
  }

  public string GetDisplayText()
  {
    return $"{this._text}";
  }
}