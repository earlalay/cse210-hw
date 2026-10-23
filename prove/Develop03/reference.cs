class Reference
{
    // attributes
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    // constructors
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
    }

    public Reference (string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    // behaviors
    public void Display()
    {
        
    }
}