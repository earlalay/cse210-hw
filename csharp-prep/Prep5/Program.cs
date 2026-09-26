using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNUmber();
        int birthYear = PromptUserBirthYear();
        int squareNumber = SquareNumber(number);
        int ageThisYear = 2026 - birthYear;

        DisplayResult(name, squareNumber, ageThisYear);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNUmber()
        {
            Console.Write("What is your favorite whole number? ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            return number;
        }

        static int PromptUserBirthYear()
        {
            Console.Write("What is your birth year? ");
            string userInput = Console.ReadLine();
            int birthYear = int.Parse(userInput);
            return birthYear;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResult(string name, int squareNumber, int ageThisYear)
        {
            Console.WriteLine($"{name}, the square of your number is {squareNumber}.");
            Console.Write($"{name}, you will turn {ageThisYear} this year.");
        }

    }
}


// static returnType FunctionName(dataType parameter1, dataType parameter2)
// {
//     // function_body
// }