class ReflectionAct : Activities
{
    private List<string> _promptList = [
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            ];
    private List<string> _subPromptList = [
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            ];
    // constructors
    public ReflectionAct(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    // behaviors
    public string GetRandomPrompt(List<string> promptList)
    {
        Random random = new Random();
        int index = random.Next(0, promptList.Count - 1);
        return promptList[index];
    }
    public void Run()
    {
        int seconds = GetDuration();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        string randomPrompt = GetRandomPrompt(_promptList);
        Console.WriteLine($" --- {randomPrompt} ---");
        bool validInput = false;
        do
        {
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        } while (!validInput);
        Console.WriteLine("Now ponder on each of the following questions as the related to this experience.");
        Console.Write("You may begin in: ");
        ShowDescendingNumbers(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        bool timeUp = false;
        do
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                string randomSubPrompt = GetRandomPrompt(_subPromptList);
                Console.Write($"> {randomSubPrompt} ");
                ShowSpinner();
                Console.WriteLine();
            }
            else
            {
                timeUp = true;
            }
        } while (!timeUp);

    }
}