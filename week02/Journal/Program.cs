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
            switch (answer)
            {
                // Now this is where I need to add functionality to whatever the user selects in the menu.
                // 1. Write -- Writing a new entry.
                case 1:
                    break;
                // 2. Display -- Displaying all of the journal entries.
                case 2:
                    break;
                // 3. Load -- Load the journal entries from a file.
                case 3:
                    break;
                // 4. Save -- Save the journal to a file.
                case 4:
                    break;
                // 5. Quit -- Exiting the journal program.
                case 5:
                    Console.WriteLine("Exiting the Journal Program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid selection. Please choose a valid option.");
                    break;
            }

            menu = new Menu();
            menu.DisplayMenu();
            answer = int.Parse(Console.ReadLine());
        
        }
    }
}