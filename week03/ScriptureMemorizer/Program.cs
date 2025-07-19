using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the book the scripture is in.
        Console.WriteLine("What book is the scripture reference in? ");
        string book = Console.ReadLine();
        Console.Clear();

        // Get the chapter the scripture is in.
        Console.WriteLine("What chapter of that book is the scripture in? ");
        int chapter = int.Parse(Console.ReadLine());
        Console.Clear();

        // Get the starting verse of the scripture.
        Console.WriteLine("What is the starting verse of that scripture? ");
        int startingVerse = int.Parse(Console.ReadLine());
        Console.Clear();

        // Find out if there is multiple verses in the scripture.
        Console.WriteLine("Is there multiple verses in the scripture? (yes / no) ");
        string answer = Console.ReadLine();
        Console.Clear();

        // Initialize the ending verse
        int endVerse = 0;

        // If there are multiple verses, get the ending verse.
        if (answer == "yes")
        {
            Console.WriteLine("What is the ending verse of that scripture? ");
            endVerse = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        // Get the text of the scripture.
        Console.WriteLine("What is the scripture's text? ");
        string scriptureText = Console.ReadLine();
        Console.Clear();

        // Instantiate Reference and Scripture
        Reference reference = new Reference(book, chapter, startingVerse, endVerse);
        Scripture scripture = new Scripture(reference, scriptureText);

        // Give initial input so the program can start.
        string input = "";
        while (input != "quit")
        {
            // If there are multiple verses, start with the reference with that constructor, otherwise, go with the one that has 3 arguments.
            if (endVerse != 0)
            {
                // Get Scripture Text
                string wordsOfScripture = scripture.GetDisplayText();
                Console.WriteLine(wordsOfScripture);

                // Add New Line
                Console.WriteLine();

                // Get User Input
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                input = Console.ReadLine();

                // If not quitting, get random number for scripture to know how many words to hide.
                if (scripture.IsCompletelyHidden())
                {
                    input = "quit";
                    Console.Clear();
                }
                else
                {
                    int random = new Random().Next(1, 5);
                    scripture.HideRandomWords(random);
                }
            }
            else
            {
                // Get Scripture Text
                string wordsOfScripture = scripture.GetDisplayText();
                Console.WriteLine(wordsOfScripture);

                // Add New Line
                Console.WriteLine();

                // Get User Input
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                input = Console.ReadLine();

                // If not quitting, get random number for scripture to know how many words to hide.
                if (scripture.IsCompletelyHidden())
                {
                    input = "quit";
                    Console.Clear();
                }
                else
                {
                    int random = new Random().Next(1, 5);
                    scripture.HideRandomWords(random);
                }
            }
        }
    }
}