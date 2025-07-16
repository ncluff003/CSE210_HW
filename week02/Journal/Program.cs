using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        menu.DisplayMenu();
        int answer = int.Parse(Console.ReadLine());

        while (answer != 5)
        {

            // Now this is where I need to add functionality to whatever the user selects in the menu.
            // 1. Write -- Writing a new entry.
            // 2. Display -- Displaying all of the journal entries.
            // 3. Load -- Load the journal entries from a file.
            // 4. Save -- Save the journal to a file.
            // 5. Quit -- Exiting the journal program.

            menu = new Menu();
            menu.DisplayMenu();
            answer = int.Parse(Console.ReadLine());
        
        }

        Console.WriteLine("Hello World! This is the Journal Project.");
    }
}