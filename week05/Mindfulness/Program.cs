using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;
        while (userInput != 4)
        {
            Console.WriteLine(
                $"1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Quit\n\nEnter your choice from this menu: (1 - 4) "
            );
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                BreathingActivity breathing = new BreathingActivity(
                    "Breathing",
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                    4
                );
                breathing.Run();
            }
            else if (userInput == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity(
                    "Reflecting",
                    "This is an activity that will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                );

                reflecting.AddPrompt("Think of a time when you stood up for someone else.");
                reflecting.AddPrompt("Think of a time when you did something really difficult.");
                reflecting.AddPrompt("Think of a time when you helped someone in need.");
                reflecting.AddPrompt("Think of a time when you did something truly selfless.");
                reflecting.AddPrompt(
                    "Think of a time when you failed in what you wanted to achieve."
                );

                reflecting.AddQuestion("Why was this experience meaningful to you?");
                reflecting.AddQuestion("What have you learned from this experience?");
                reflecting.AddQuestion("In what way, if possible, could you have improved?");
                reflecting.AddQuestion("What would you do differently, if you could?");
                reflecting.AddQuestion("Have you ever done anything like this before?");
                reflecting.AddQuestion("How did you get started?");
                reflecting.AddQuestion("If completed, how did you feel when it was completed?");
                reflecting.AddQuestion(
                    "If you were, what made this time different than other times you were not as successful?"
                );
                reflecting.AddQuestion("What is your favorite thing about this experience?");
                reflecting.AddQuestion(
                    "What could you learn from this experience that applies to other situations?"
                );
                reflecting.AddQuestion(
                    "What did you learn about yourself through this experience?"
                );
                reflecting.AddQuestion("How can you keep this experience in mind in the future?");

                reflecting.Run();
            }
            else if (userInput == 3)
            {
                ListingActivity listing = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                );

                listing.AddPrompt("Who are the people that you appreciate?");
                listing.AddPrompt("What are personal strengths of yours?");
                listing.AddPrompt("Who are people that you have helped this week?");
                listing.AddPrompt("When have you felt the Holy Ghost this month?");
                listing.AddPrompt("Who are some of your personal heroes?");
                listing.AddPrompt(
                    "What are some things you can learn from a recent difficult period?"
                );
                listing.AddPrompt(
                    "How have you noticed the hand of God in your own life this month?"
                );

                listing.Run();
            }
            else
            {
                Console.WriteLine("\nHave a nice day!");
            }
        }
    }
}
