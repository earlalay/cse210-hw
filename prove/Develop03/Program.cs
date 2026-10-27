using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        bool programFinished = false;

        do
        {
            Console.WriteLine($"{reference.BuildReference()}{scripture.BuildDisplayedScripture()}");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            input = input.ToLower();

            if ((input == "" && scripture.IsAllHidden()) || input == "quit")
            {
                programFinished = true;
            }
            else if (input == "")
            {
                scripture.HideNewWords();
                Console.Clear();                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input.");
                Console.WriteLine();                
            }

        } while (!programFinished);


    }
}