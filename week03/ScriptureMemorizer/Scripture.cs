using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int num = 1)
    {
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();
        var random = new Random();

        for (int i = 0; i < num && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        return reference.GetDisplayText() + " - " + string.Join(" ", words.Select(w => w.GetDisplayText()));
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }
}
