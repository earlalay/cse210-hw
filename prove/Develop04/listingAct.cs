class ListingAct : Activities
{
    private List<string> _prompts = [
                                        "Who are people that you appreciate?",
                                        "What are personal strengths of yours?",
                                        "Who are people that you have helped this week?",
                                        "When have you felt the Holy Ghost this month?",
                                        "Who are some of your personal heroes?"
                                    ];
    // constructors
    public ListingAct(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    // behaviors
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count - 1);
        return _prompts[index];
    }
    public void Run()
    {
        int seconds = GetDuration();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($" --- {randomPrompt} ---");
        Thread.Sleep(1000);
        Console.Write("You may begin in: ");
        ShowDescendingNumbers(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        bool timeUp = false;
        do
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                Console.Write($"> ");
                Console.ReadLine();
            }
            else
            {
                timeUp = true;
            }
        } while (!timeUp);
    }
}