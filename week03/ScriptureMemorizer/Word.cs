class Word
{
    private string _originalWord; // The word
    public bool IsHidden { get; private set; } // Check if word is hidden

    // Constructor to store the word
    public Word(string originalWord)
    {
        _originalWord = originalWord;
        IsHidden = false; // Word starts visible
    }

    // Hide the word
    public void Hide()
    {
        IsHidden = true;
    }

    // Show the word or underscores
    public string GetDisplayText()
    {
        return IsHidden ? new string('_', _originalWord.Length) : _originalWord;
    }
}
