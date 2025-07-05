using System;

class Program
{
    static void Main(string[] args)
    {
        bool answer = true;
        do
        {
            int guesses = 0;
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 101);
            int magicNumber = randomNumber;
            int guess = -1;
            do
            {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You got it in {guesses} guesses! Great job!");
                }
            } while (guess != magicNumber);

            Console.WriteLine("Do you want to play again? (e.g. yes / no)");
            string response = Console.ReadLine();

            if (response == "yes")
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
        } while (answer == true);
    }
}