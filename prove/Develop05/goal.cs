public abstract class Goal {
    // attributes
    protected string _title;
    protected string _description;
    protected int _points;

    // constructors
    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }
    
    // behaviors
    public abstract void ShowDescription();
    public abstract void GetSaveString();
    public int GetPoints()
    {
        
    }
}