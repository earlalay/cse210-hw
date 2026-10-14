class Entry
{
    // attributes
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Today.ToString("MM/dd/yyyy");
    }

    // behaviors

    public string FormatEntry(Entry newEntry)
    {
        string formattedEntry = $"{newEntry._date}||{newEntry._prompt}||{newEntry._response}";
        return formattedEntry;
    }
}