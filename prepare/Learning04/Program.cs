using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Alayna Earl", "Math");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("7.3", "8-19", "Roberto Rodriguez", "Fractions");

        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War 2", "Mary Waters", "European History");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}