class Scripture
{
    // attributes
    private List<Word> _wordList = new List<Word>();
    private string _scripture = "";

    // constructors
    public Scripture(string scripture)
    {
        _scripture = scripture;
        BuildWordList(scripture);
    }

    // behaviors

    private void BuildWordList(string scripture)
    {
        string[] scriptureWords = scripture.Split(" ");
        foreach (string text in scriptureWords)
        {
            Word word  = new Word(text);
            _wordList.Add(word);
        }
    }

    public string BuildDisplayedScripture()
    {
        string displayedScripture = "";
        foreach (Word word in _wordList)
        {
            displayedScripture += $" {word.BuildDisplayedWord()}";
        }
        return displayedScripture;
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _wordList)
        {
            if (!word.GetIsHidden()) {
                return false;
            }
        }
        return true;
    }

    private List<Word> VisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _wordList)
        {
            if (!word.GetIsHidden())
            {
                visibleWords.Add(word);
            }
        }
        return visibleWords;
    }

    public void HideNewWords()
    {
        List<Word> visibleWords = VisibleWords();
        Random random = new Random();
        int count = 0;
        do
        {
            int index = random.Next(visibleWords.Count);
            Word selectedWord = visibleWords[index];
            selectedWord.SetIsHidden(true);
            visibleWords.RemoveAt(index);
            count += 1;
        } while (visibleWords.Count > 0 && count < 3);

    }
}