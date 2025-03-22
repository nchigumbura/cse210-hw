class Reference
{
    private string _book; // Book name
    private string _chapterAndVerse; // Chapter and verse(s)

    // Constructor to parse book and chapter/verse from a string input
    public Reference(string reference)
    {
        var parts = reference.Split(' ');
        _book = parts[0];
        _chapterAndVerse = parts[1];
    }

    // Format the reference for display (e.g., "John 3:16")
    public string GetFormattedReference()
    {
        return $"{_book} {_chapterAndVerse}";
    }
}
