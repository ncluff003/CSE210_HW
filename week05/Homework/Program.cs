using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string mathSummary = math.GetSummary();
        string mathHomework = math.GetHomeworkList();
        Console.WriteLine(mathSummary);
        Console.WriteLine(mathHomework);

        WritingAssignment writing = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );

        string writingSummary = writing.GetSummary();
        string writingPaper = writing.GetWritingInformation();
        Console.WriteLine(writingSummary);
        Console.WriteLine(writingPaper);
    }
}
