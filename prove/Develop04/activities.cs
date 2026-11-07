class Activities
{
    // attributes
    private string _name;
    private string _description;
    private int _duration;
    private List<string> _spinnerPositions = ["|", "/", "-", "\\", "|", "/", "-", "\\"];

    // constructors
    public Activities(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // behaviors

    protected int GetDuration()
    {
        return _duration;
    }
    public void ShowPrologue()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        do
        {
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int duration) && duration > 0)
            {
                _duration = duration;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        } while (_duration < 1);
        Thread.Sleep(100);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
    }

    public void ShowSpinner()
    {
        foreach (string s in _spinnerPositions)
        {
            Console.Write(s);
            Thread.Sleep(625);
            Console.Write("\b \b");
        }
    }

    public void ShowEpilogue()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner();
        Console.Clear();
    }

    protected void ShowDescendingNumbers(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}