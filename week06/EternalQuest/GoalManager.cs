using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private List<string> _menu = new List<string>();

    public GoalManager()
    {
        this._goals = new List<Goal>();
        this._score = 0;
    }

    public void AddToScore(int points)
    {
        this._score += points;
    }

    public void AddGoal(Goal goal)
    {
        this._goals.Add(goal);
    }

    public void ShowMenu()
    {
        foreach (string item in _menu)
        {
            Console.WriteLine(item);
        }
    }

    public void Start()
    {
        this._menu.Add("1. Create New Goal");
        this._menu.Add("2. List Goals");
        this._menu.Add("3. Save Goals");
        this._menu.Add("4. Load Goals");
        this._menu.Add("5. Record Event");
        this._menu.Add("6. Quit");
        this.ShowMenu();
        int answer = int.Parse(Console.ReadLine());
        ;
        while (answer != 6)
        {
            Console.WriteLine($"You have {this._score} points.");
            Console.WriteLine();
            switch (answer)
            {
                case 1:
                    Console.Clear();
                    this.CreateGoal();
                    Console.WriteLine("Goal created successfully!");
                    break;
                case 2:
                    Console.Clear();
                    this.ListGoals();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Enter the filename to save the goals to: ");
                    string saveFile = Console.ReadLine();
                    this.SaveGoals(saveFile);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Enter the filename to load the goals from: ");
                    string loadFile = Console.ReadLine();
                    this.LoadGoals(loadFile);
                    break;
                case 5:
                    RecordEvent();
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Exiting the Eternal Quest Program. Goodbye!");
                    break;
            }
            this.ShowMenu();
            answer = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Exiting the Eternal Quest Program. Goodbye!");
    }

    public string DisplayPlayerInfo()
    {
        return "";
    }

    public void ListGoals()
    {
        Console.WriteLine($"You have {this._score} points.");
        Console.WriteLine();

        int goalCount = 0;
        foreach (Goal goal in _goals)
        {
            goalCount++;
            Console.WriteLine($"{goalCount}. {goal.GetStringRepresentation()}");
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        List<string> goalTypes = new List<string>();
        goalTypes.Add("1. Simple Goal");
        goalTypes.Add("2. Eternal Goal");
        goalTypes.Add("3. Checklist Goal");

        Console.WriteLine("There are three types of goals you can create.");
        Console.WriteLine();
        foreach (string goalType in goalTypes)
        {
            Console.WriteLine(goalType);
        }

        Console.WriteLine("Which would you like to create? (1-3)");

        int answer = int.Parse(Console.ReadLine());

        string goalName;
        string goalDescription;
        int goalPoints;
        int goalTarget;
        int bonusPoints;

        switch (answer)
        {
            case 1:
                Console.WriteLine("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.WriteLine("Please give a short description of your goal: ");
                goalDescription = Console.ReadLine();
                Console.WriteLine("How many points would you want this goal to be? ");
                goalPoints = int.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                this.AddGoal(simpleGoal);
                break;
            case 2:
                Console.WriteLine("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.WriteLine("Please give a short description of your goal: ");
                goalDescription = Console.ReadLine();
                Console.WriteLine("How many points would you want this goal to be? ");
                goalPoints = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                this.AddGoal(eternalGoal);
                break;
            case 3:
                Console.WriteLine("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.WriteLine("Please give a short description of your goal: ");
                goalDescription = Console.ReadLine();
                Console.WriteLine("How many points would you want this goal to be? ");
                goalPoints = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times would you like to complete this goal? ");
                goalTarget = int.Parse(Console.ReadLine());
                Console.WriteLine(
                    "How many bonus points would you like to earn for accomplishing the target number? "
                );
                bonusPoints = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(
                    goalName,
                    goalDescription,
                    goalPoints,
                    goalTarget,
                    bonusPoints
                );
                this.AddGoal(checklistGoal);
                break;
        }
    }

    public void RecordEvent()
    {
        Console.Clear();
        this.ListGoals();
        Console.WriteLine("Which goal did you accomplish? (Enter the number)");
        int goalNumber = int.Parse(Console.ReadLine());
        if (goalNumber < 1 || goalNumber > this._goals.Count)
        {
            Console.WriteLine("Invalid goal number. Please try again.");
            return;
        }
        Goal selectedGoal = this._goals[goalNumber - 1];
        selectedGoal.RecordEvent();
        this.AddToScore(selectedGoal.RetrievePoints());

        Console.WriteLine(
            $"Congratulations! You have earned {selectedGoal.RetrievePoints()} points."
        );
        Console.WriteLine($"Your total score is now {this._score} points.");
    }

    public void SaveGoals(string file)
    {
        // Iterate through the entries and save them to a file.
        using (StreamWriter writer = new StreamWriter(file))
        {
            // First write the total number of points.
            writer.WriteLine($"{this._score}");
            foreach (Goal goal in this._goals)
            {
                // Use Each Goal Type's Method To Write Details To The File.
                writer.WriteLine(goal.WriteDetails());
                writer.WriteLine("-------------------------------");
                writer.WriteLine(); // Adding an extra line for better readability.
            }
        }
    }

    public void LoadGoals(string file)
    {
        int index = 0;
        // Start Reading A File
        string[] lines = System.IO.File.ReadAllLines(file);
        // Read Each Line & Create Entry Objects
        Console.WriteLine("Loading entries from file...");

        string name = "";
        string description = "";
        int points = 0;
        int target = 0;
        int bonus = 0;
        int amountCompleted = 0;
        bool isComplete = false;

        foreach (string line in lines)
        {
            if (index == 0)
            {
                // The first line is the score.
                this._score = int.Parse(line);
                index++;
                continue;
            }
            if (line.StartsWith("Simple Goal:"))
            {
                // Remove the prefix and split the details.
                string[] parts = line.Substring(12).Split('|');
                int partIndex = 0;
                foreach (string part in parts)
                {
                    if (partIndex == 0)
                    {
                        name = part;
                    }
                    else if (partIndex == 1)
                    {
                        description = part;
                    }
                    else if (partIndex == 2)
                    {
                        points = int.Parse(part);
                    }
                    else if (partIndex == 3)
                    {
                        // This part is the completion status.
                        isComplete = bool.Parse(part);
                    }
                    partIndex++;
                }
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                if (isComplete)
                {
                    simpleGoal.MarkAsComplete();
                }
                this.AddGoal(simpleGoal);
            }
            else if (line.StartsWith("Eternal Goal:"))
            {
                // Remove the prefix and split the details.
                string[] parts = line.Substring(13).Split('|');
                int partIndex = 0;
                foreach (string part in parts)
                {
                    if (partIndex == 0)
                    {
                        name = part;
                    }
                    else if (partIndex == 1)
                    {
                        description = part;
                    }
                    else if (partIndex == 2)
                    {
                        points = int.Parse(part);
                    }
                    partIndex++;
                }
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                this.AddGoal(eternalGoal);
            }
            else if (line.StartsWith("Checklist Goal:"))
            {
                // Remove the prefix and split the details.
                string[] parts = line.Substring(15).Split('|');

                int partIndex = 0;
                foreach (string part in parts)
                {
                    if (partIndex == 0)
                    {
                        name = part;
                    }
                    else if (partIndex == 1)
                    {
                        description = part;
                    }
                    else if (partIndex == 2)
                    {
                        points = int.Parse(part);
                    }
                    else if (partIndex == 3)
                    {
                        // Target number of completions.
                        bonus = int.Parse(part);
                    }
                    else if (partIndex == 4)
                    {
                        // Bonus points for completing the target.
                        amountCompleted = int.Parse(part);
                    }
                    else if (partIndex == 5)
                    {
                        // Amount completed.
                        target = int.Parse(part);
                        Console.WriteLine(amountCompleted);
                        ChecklistGoal checklistGoal = new ChecklistGoal(
                            name,
                            description,
                            points,
                            target,
                            bonus
                        );
                        checklistGoal.SetAmountCompleted(amountCompleted);
                        this.AddGoal(checklistGoal);
                    }
                    partIndex++;
                }
            }
            else
            {
                continue; // This line is not a goal line. Skip it.
            }
        }
    }
}
