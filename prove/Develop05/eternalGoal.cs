public class EternalGoal : Goal
{
    // attributes
    int _timesDone = 0;
    // constructors
    public EternalGoal(string title, string description, int points):
                       base(title, description, points){}

    // behaviors
    public override void ShowDescription()
    {
        Console.WriteLine($"[ ] {_title} ({_description})");
    }
    public override string GetSaveString()
    {
        return $"EternalGoal||{_title}||{_description}||{_points}";
    }
    public override void IncreaseTimesDone()
    {
        _timesDone += 1;
    }
    public override int GetPoints()
    {
        return _points * _timesDone;
    }
    public override bool GetCompleted()
    {
        return false;
    }
}