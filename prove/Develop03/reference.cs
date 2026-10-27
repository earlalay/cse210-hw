class Reference
{
    // attributes
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse = 0;

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
    public string BuildReference()
    {
        string reference;
        if (_lastVerse == 0)
        {
            reference = $"{_book} {_chapter}:{_firstVerse}";
        }
        else
        {
            reference = $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
        return reference;
    }
}