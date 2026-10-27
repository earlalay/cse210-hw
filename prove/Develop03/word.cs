class Word
{
    // attributes
    private string _word = "";
    private bool _isHidden;

    // constructors
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
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

    public string BuildDisplayedWord()
    {
        string displayedWord = "";
        if (_isHidden)
        {
            foreach (char character in _word)
            {
                if (char.IsLetter(character))
                {
                    displayedWord += "_";
                }
                else
                {
                    displayedWord += $"{character}";
                }
            }
        }
        else
        {
            displayedWord = _word;
        }
            
        return displayedWord;
    }
}