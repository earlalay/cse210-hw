class Journal
{
    // attributes
    List<Entry> currentEntries = new List<Entry>();
    List<Entry> oldEntries = new List<Entry>();
    List<string> prompts = new List<string>();
    string filename = "";

    // behaviors
    public void AddEntry(Entry entry, List<Entry> currentEntries)
    {
        
    }

    public void DisplayEntries(List<Entry> oldEntries, List<Entry> currentEntries)
    {
        
    }

    public List<string> LoadJournal(string filename, List<Entry> oldEntries, List<Entry> currentEntries)
    {
        
    }

    public void SaveJournal(string filename, List<Entry> oldEntries, List<Entry> currentEntries)
    {
        
    }
}