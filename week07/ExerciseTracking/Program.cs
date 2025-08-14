using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(DateTime.Now, "Running", 30, 5.0));
        activities.Add(new StationaryBike(DateTime.Now, "Cycling", 45, 20));
        activities.Add(new Swimming(DateTime.Now, "Swimming", 60, 3));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
