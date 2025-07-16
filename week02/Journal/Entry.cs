using System;

public class Entry
{
  public string _date;
  public string _promptText;
  public string _entryText;

  public void DisplayEntry()
  {
    Console.WriteLine($"Date: {this._date}  |  Prompt: {this._promptText}");
    Console.WriteLine($"Entry: {this._entryText}");
  }
}