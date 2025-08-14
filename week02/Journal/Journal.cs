using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void StartEntry()
    {
        // Get A Random Prompt & Store It To Put In The Entry
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();
        // Get The Date
        string date = DateTime.Now.ToString("dd/MM/yyyy");
        // Get The User's Input For The Entry
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("> ");
        string entryText = Console.ReadLine();
        // Create A New Entry Object & Add It To The List
        Entry newEntry = new Entry
        {
            _date = date,
            _promptText = prompt,
            _entryText = entryText,
        };

        // Add The New Entry To The List
        AddEntry(newEntry);
    }

    public void AddEntry(Entry newEntry)
    {
        // Add the entry to the list of entries.
        this._entries.Add(newEntry);
    }

    public void SaveToFile(string file)
    {
        // Iterate through the entries and save them to a file.
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date}  |  Prompt: {entry._promptText}");
                writer.WriteLine($"Entry: {entry._entryText}");
                writer.WriteLine("-------------------------------");
                writer.WriteLine(); // Adding an extra line for better readability.
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Start Reading A File
        string[] lines = System.IO.File.ReadAllLines(file);
        // Read Each Line & Create Entry Objects
        Console.WriteLine("Loading entries from file...");
        string entryDate = "";
        string entryPrompt = "";
        string entryText = "";

        foreach (string line in lines)
        {
            //
            // Get the date, prompt, and entry text from the line.
            if (line.StartsWith("Date: "))
            {
                string[] parts = line.Split("  |  Prompt: ");
                Console.WriteLine(parts);
                if (parts.Length == 2)
                {
                    entryDate = parts[0].Substring(6); // Remove "Date: "
                    entryPrompt = parts[1];
                    Console.WriteLine($"{entryDate}");
                    Console.WriteLine($"{entryPrompt}");
                }
            }
            else if (line.StartsWith("Entry: "))
            {
                entryText = line.Substring(7); // Remove "Entry: "
                Console.WriteLine($"{entryDate}");
                Console.WriteLine($"{entryPrompt}");

                // Create a new Entry object with the extracted data.
                Entry entry = new Entry
                {
                    _date = entryDate,
                    _promptText = entryPrompt,
                    _entryText = entryText,
                };

                // Add Each Entry Object To The List
                AddEntry(entry);
            }
        }
        // Close The File
        // Display A Message Indicating The Load Was Successful
        Console.WriteLine("Entries loaded successfully.");
    }

    public void DisplayAll()
    {
        // Iterate Through The Entries & Display Each One's Date, Prompt, and Entry Text
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine("-------------------------------");
            Console.WriteLine(); // Adding an extra line for better readability.
        }
    }
}
