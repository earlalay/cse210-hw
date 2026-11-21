public class SimpleGoal : Goal
{
    // attributes
    private bool _completed = false;

    // constructors
    public SimpleGoal(string title, string description, int points):
                      base(title, description, points) {}

     public SimpleGoal(string title, string description, int points, bool completionStatus):
                       base(title, description, points)
    {
        _completed = completionStatus;
    }

    // behaviors
    public override void ShowDescription()
    {
        string inBrackets = " ";
        if (_completed)
        {
            inBrackets = "X";
        }
        Console.WriteLine($"[{inBrackets}] {_title} ({_description})");
    }
    public override string GetSaveString()
    {
        return $"SimpleGoal||{_title}||{_description}||{_points}||{_completed}";
    }
    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }
    public override int GetPoints()
    {
        if (_completed)
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }
    public override bool GetCompleted()
    {
        return _completed;
    }
    public override void IncreaseTimesDone()
    {
        _completed = true;
    }
}