class Word
{
    private string _originalWord; // The actual word
    public bool IsHidden { get; private set; } // True if the word is hidden

    // Save the word and mark it as not hidden
    public Word(string originalWord)
    {
        _originalWord = originalWord;
        IsHidden = false;
    }

    // Hide the word by replacing it with underscores
    public void Hide()
    {
        IsHidden = true;
    }

    // Reveal the word (used for the hint system)
    public void Unhide()
    {
        IsHidden = false;
    }

    // Return the word or underscores based on its hidden state
    public string GetDisplayText()
    {
        return IsHidden ? new string('_', _originalWord.Length) : _originalWord;
    }
}
