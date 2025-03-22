class Reference
{
    private string _book; // Book of the scripture
    private string _chapterAndVerse; // Chapter and verse

    // Constructor to split book and verse
    public Reference(string reference)
    {
        var parts = reference.Split(' ');
        _book = parts[0];
        _chapterAndVerse = parts[1];
    }

    // Get formatted reference
    public string GetFormattedReference()
    {
        return $"{_book} {_chapterAndVerse}";
    }
}
