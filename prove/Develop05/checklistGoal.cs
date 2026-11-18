public class ChecklistGoal : Goal
{
    // attributes
    private int _timesDone;
    private int _timesDoneGoal;
    private int _bonusPoints;

    // constructors
    public ChecklistGoal(string title, string description, int points, int timesDoneGoal) : base(title, description, points)
    {
        _timesDoneGoal = timesDoneGoal;
    }

    // behaviors
    public void IncreaseTimesDone()
    {
        
    }
    public bool IsDone()
    {
        
    }
    public override void ShowDescription()
    {
        
    }
    public override void GetSaveString()
    {
        
    }
}