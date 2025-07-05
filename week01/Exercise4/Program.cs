using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");

        do
        {
            userNumber = float.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        float sum = 0;
        float maximum = 0;
        float minimum = 999999999999999999;

        foreach (int number in numbers)
        {
            sum += number;
            if (maximum < number)
            {
                maximum = number;
            }
            if (minimum > number && number > 0)
            {
                minimum = number;
            }
        }
        float average = sum / numbers.Count;

        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
        Console.WriteLine($"The smallest positive number is: {minimum}");
        Console.WriteLine($"The sorted list is: {string.Join(", ", numbers)}");
    }
}