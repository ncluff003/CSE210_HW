using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        float grade = float.Parse(Console.ReadLine());
        string letter;
        string sign = "";
        float gradeRemainder = grade % 10;

        if (gradeRemainder >= 7)
        {
            sign = "+";
        }
        else if (gradeRemainder < 3)
        {
            sign = "-";
        }

        if (grade >= 90)
        {
            if (sign == "-")
            {
                letter = $"A{sign}";
            }
            else
            {
                letter = "A";
            }
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = $"B{sign}";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = $"C{sign}";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = $"D{sign}";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}