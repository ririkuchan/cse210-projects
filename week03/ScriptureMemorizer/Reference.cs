public class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int VerseStart { get; }
    public int? VerseEnd { get; }

    public Reference(string book, int chapter, int verseStart, int? verseEnd = null)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        return VerseEnd.HasValue
            ? $"{Book} {Chapter}:{VerseStart}-{VerseEnd}"
            : $"{Book} {Chapter}:{VerseStart}";
    }
}
