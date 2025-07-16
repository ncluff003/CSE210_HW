using System;

public class Menu
{
  public List<string> _menu = new List<string>
  {
    "Please select one of the following choices:",
    "---------------------------------",
    "1. Write",
    "2. Display",
    "3. Load",
    "4. Save",
    "5. Quit",
    "What would you like to do? (1-5)"
  };
  public void DisplayMenu()
  {
    foreach (string item in _menu)
    {
      Console.WriteLine(item);
    }
  }
}