public class SimpleGoal : Goal
{
    // attributes
    private bool _completed = false;

    // constructors
    public SimpleGoal(string title, string description, int points) : base(title, description, points) {}

    // behaviors
    public override void ShowDescription()
    {
        
    }
    public override void GetSaveString()
    {
        
    }
}