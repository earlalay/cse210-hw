public class ChecklistGoal : Goal
{
    // attributes
    private int _timesDone = 0;
    private int _timesDoneGoal;

    // constructors
    public ChecklistGoal(string title, string description, int points, int timesDoneGoal):
                         base(title, description, points)
    {
        _timesDoneGoal = timesDoneGoal;
    }

    public ChecklistGoal(string title, string description, int points, int timesDone, int timesDoneGoal):
                         base(title, description, points)
    {
        _timesDone = timesDone;
        _timesDoneGoal = timesDoneGoal;
    }

    // behaviors
    public override void IncreaseTimesDone()
    {
        _timesDone += 1;
    }
    public override void ShowDescription()
    {
        string inBrackets = " ";
        if (_timesDone == _timesDoneGoal)
        {
            inBrackets = "X";
        }
        Console.WriteLine($"[{inBrackets}] {_title} ({_description}) -- Completed: {_timesDone}/{_timesDoneGoal}");
    }
    public override string GetSaveString()
    {
        return $"ChecklistGoal||{_title}||{_description}||{_points}||{_timesDone}||{_timesDoneGoal}";
    }
    public override int GetPoints()
    {
        int currentPoints = _points * _timesDone;
        if (_timesDone == _timesDoneGoal)
        {
            currentPoints = currentPoints + (_points * 5);
        }
        return currentPoints;
    }
    public override bool GetCompleted()
    {
        return _timesDone == _timesDoneGoal;
    }
}