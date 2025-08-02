using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _count;

    public ListingActivity(string activity, string description)
        : base(activity, description) { }
}
