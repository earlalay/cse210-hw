using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int magicNumber = int.Parse(userInput);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            
        } while (guess != magicNumber);

        Console.Write("You guessed it!");
    }
}