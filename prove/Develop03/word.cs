class Word
{
    // attributes
    private string _word = "";
    private bool _isHidden = false;

    // constructors
    public Word()
    {
        
    }

    // behaviors
    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public void Display()
    {
        // maybe get rid of this and just display from scripture?
    }
}