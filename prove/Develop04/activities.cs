class Activities
{
    // attributes
    private string _name;
    private string _description;
    private int _duration;

    // constructors
    public Activities(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public Activities(string name, string description)
    {
        _name = name;
        _description = description;
    }
    // behaviors
    public void ShowPrologue()
    {
        
    }

    public void ShowSpinner(int seconds)
    {
        
    }

    public void ShowEpilogue()
    {
        
    }
}