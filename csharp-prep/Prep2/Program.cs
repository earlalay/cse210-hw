using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("What was your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradeNum = int.Parse(userInput);

        string letter = "Z";

        if (gradeNum >= 90)
        {
            letter = "A";
        }
        else if (gradeNum >= 80)
        {
            letter = "B";
        }
        else if (gradeNum >= 70)
        {
            letter = "C";
        }
        else if (gradeNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"You got an {letter}.");
        }
        else
        {
            Console.WriteLine($"You got a {letter}.");
        }

        if (gradeNum >= 70)
        {
            Console.Write("You passed the class!");
        }
        else
        {
            Console.Write("You didn't pass, but I know you can get there!");
        }

    }
}